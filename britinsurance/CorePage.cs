using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace britinsurance
{
    internal class CorePage
    {
        public static IWebDriver driver;

        public static void SeleniumInit( string browser)
        {
            if(browser=="Chrome") {

                var chromeOptions= new ChromeOptions();
                chromeOptions.AddArguments("--start-maximized");
                chromeOptions.AddArguments("--incognito");
                IWebDriver chromedriver = new ChromeDriver(chromeOptions);
                driver = chromedriver;

            }
            else if (browser == "FireFox")
            {
                FirefoxOptions firefoxOptions= new FirefoxOptions();
                firefoxOptions.AddArguments("");
                IWebDriver firefoxdriver = new FirefoxDriver(firefoxOptions);

                driver = firefoxdriver;

            }


        }

    }
}
