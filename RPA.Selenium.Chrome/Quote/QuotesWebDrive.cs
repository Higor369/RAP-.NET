using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RPA.Selenium.Chrome.Quote;
public class QuotesWebDrive : IDisposable
{
    private IWebDriver _drive;

    public QuotesWebDrive()
    {
        _drive = new ChromeDriver();
    }

    public void Login(string username, string password)
    {
        _drive.Navigate().GoToUrl("https://quotes.toscrape.com/login");

        _drive.FindElement(By.Id("username")).SendKeys(username);
        _drive.FindElement(By.Id("password")).SendKeys(password);

        _drive.FindElement(By.XPath("/html/body/div/form/input[2]")).Click();
    }

    public List<Quotes> GetQuotes( string numberPage = "1")
    { 
        var quotesList = new List<Quotes>();

        _drive.Navigate().GoToUrl($"https://quotes.toscrape.com/page/{numberPage}/");

        var elementsQuotes = _drive.FindElements(By.ClassName("quote"));

        foreach (var item in elementsQuotes)
        {
            var quote = new Quotes();
            quote.Title = item.FindElement(By.ClassName("text")).Text;
            quote.Author = item.FindElement(By.ClassName("author")).Text;
            quote.tags = item.FindElements(By.ClassName("tag")).Select(x => x.Text).ToList();
            quotesList.Add(quote);
        }
        return quotesList;
    }

    public void Dispose()
    {
        _drive.Dispose();
    }

}
