using EasyAutomationFramework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWPFBitcoin.Driver
{
    public class BitcoinDriver : Web
    {
        public BitcoinDriver()
        {
            this.StartBrowser();
        }

        public EasyReturn.Web StartBrowser(TypeDriver typeDriver = TypeDriver.GoogleChorme, string pathCache = null)
        {
            try
            {
             
                ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
                chromeDriverService.HideCommandPromptWindow = true;
                ChromeOptions chromeOptions = new ChromeOptions();
                if (string.IsNullOrEmpty(pathCache))
                {
                    chromeOptions.AddArgument("--incognito");
                }
                else
                {
                    chromeOptions.AddArgument("user-data-dir=" + pathCache);
                }
                chromeOptions.AddArgument("--headless");
                chromeOptions.AddExcludedArgument("enable-automation");
                chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
                chromeOptions.AddArgument("--start-maximized");
                driver = new ChromeDriver(chromeDriverService, chromeOptions);
                          

                return new EasyReturn.Web
                {
                    driver = driver,
                    Sucesso = true
                };
            }
            catch (Exception ex)
            {
                return new EasyReturn.Web
                {
                    driver = driver,
                    Sucesso = false,
                    Error = ex.Message.ToString()
                };
            }
        }

        public double GetValueBitcoin()
        {
            Navigate("https://www.google.com.br/search?q=valor+do+bitcoin&sxsrf=AB5stBgOC4VXCz95HLKjfOoVH3Zq2EdIYA%3A1690310015251&source=hp&ei=fxXAZOjjDLrW5OUPyKW4wAQ&iflsig=AD69kcEAAAAAZMAjj5P4wX84bRWXTjuoZV4vKf1qhO50&ved=0ahUKEwion5HAv6qAAxU6K7kGHcgSDkgQ4dUDCAk&uact=5&oq=valor+do+bitcoin&gs_lp=Egdnd3Mtd2l6IhB2YWxvciBkbyBiaXRjb2luMgsQABiABBixAxiDATILEAAYgAQYsQMYgwEyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABEiEHVC6CVi4G3ABeACQAQCYAYYBoAHtDqoBBDAuMTa4AQPIAQD4AQGoAgrCAgcQIxjqAhgnwgIEECMYJ8ICBxAjGIoFGCfCAgsQLhiABBixAxiDAcICCxAuGIMBGLEDGIAEwgIIEAAYgAQYsQPCAhEQLhiABBixAxiDARjHARjRA8ICCxAAGIoFGLEDGIMBwgIOEC4YgAQYsQMYxwEY0QPCAggQLhiABBixA8ICCxAAGIAEGLEDGMkDwgIIEAAYigUYkgPCAgQQABgD&sclient=gws-wiz");

            var bitcoin = GetValue(TypeElement.Xpath, "//*[@id=\"crypto-updatable_2\"]/div[3]/div[2]/span[1]");

            if (bitcoin.Sucesso)
            {
                var valid = double.TryParse(bitcoin.Value, out double result);
                if (valid) return result;
            }

            return 0;
        }

        public bool ChecksValueBitoinIsDesired(double valueCurrent, double valueDesired)
        {
            if (valueCurrent <= valueDesired) return true;
            return false;
        }
    }
}
