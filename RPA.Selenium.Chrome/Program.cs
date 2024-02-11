using RPA.Selenium.Chrome.Quote;

using(var quote = new QuotesWebDrive())
{
    quote.Login("higor", "123456");

    var list = quote.GetQuotes();
}

