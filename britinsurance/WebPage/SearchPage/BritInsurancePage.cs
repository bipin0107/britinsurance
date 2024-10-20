using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;


namespace britinsurance
{
    internal class BritInsurancePage 

    {

        private IWebDriver driver;

        public BritInsurancePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By searchButton = By.XPath("//button[@type='button']");
        private By searchInput = By.XPath("//input[@type='search']");
        private By searchResults = By.XPath("//div[@class='header--search__results']//div[@class='result']");

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://www.britinsurance.com/");
        }

        public void ClickSearchButton()
        {
            driver.FindElement(searchButton).Click();
        }

        public void EnterSearchText(string searchText)
        {
            driver.FindElement(searchInput).SendKeys(searchText + Keys.Enter);
        }

        public IList<IWebElement> GetSearchResults()
        {
            return driver.FindElements(searchResults);
        }
    }


}

