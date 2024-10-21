using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Data;

namespace britinsurance
{
    [TestClass]
    public class TestExecution
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "Search_TC001",DataAccessMethod.Sequential)]
        public void Search_TC001()
        {
            CorePage.SeleniumInit("Chrome");
            IWebDriver driver = CorePage.driver;


            // Create an instance of BritInsurancePage
            BritInsurancePage britPage = new BritInsurancePage(driver);

            // Go to the website
            britPage.GoToPage();
            Thread.Sleep(5000);

           // string searchtext1 = TestContext.DataRow["text"].ToString();

            // Perform the search
            britPage.ClickSearchButton();
            britPage.EnterSearchText("IFRS 17");

            // Get search results
            IList<IWebElement> results = britPage.GetSearchResults();

            Console.WriteLine("Search result count:"+results );

            // Print each result
            foreach (var result in results)
            {
                Console.WriteLine(result.Text);
            }

            // Check the specific title in results            
            bool titleFound = results.Any(result => result.Text.Contains("Interim results for the six months ended 30 June 2022"));
            if (titleFound)
            {
                Console.WriteLine("Specific title found in search results.");
            }
            else
            {
                Console.WriteLine("Specific title not found in search results.");
            }

           



           driver.Close();
        }
        }
}
