using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject
{
    class TestClass
    {
        static void Main(string[] args)
        {
            // Initialize ChromeDriver
            IWebDriver driver = new ChromeDriver();

            // Navigate to the Google homepage
            driver.Navigate().GoToUrl("https://www.waikatocleaning.co.nz/");

            /*// Find the search input element by its name
            IWebElement searchBox = driver.FindElement(By.Name("q"));

            // Type "Selenium" into the search input
            searchBox.SendKeys("Selenium");

            // Submit the form (in this case, hitting Enter key)
            searchBox.SendKeys(Keys.Enter);

            // Wait for the search results to load (you should use explicit waits in production)
            System.Threading.Thread.Sleep(3000);

            // Assert that the title contains the keyword "Selenium"
            if (driver.Title.Contains("Selenium"))
            {
                Console.WriteLine("Test Passed! Google search results for 'Selenium' found.");
            }
            else
            {
                Console.WriteLine("Test Failed! Google search results for 'Selenium' not found.");
            }*/

            IWebElement nameTextBox = driver.FindElement(By.XPath("//*[@id=\"Name-Business\"]"));
            nameTextBox.SendKeys("Santosh");

            IWebElement mobileTextBox = driver.FindElement(By.XPath("//*[@id=\"Number\"]"));
            mobileTextBox.SendKeys("321");

            IWebElement emailTextBox = driver.FindElement(By.XPath("//*[@id=\"Quote-Email\"]"));
            emailTextBox.SendKeys("sumfa@gm.co");

            IWebElement msgTextBox = driver.FindElement(By.XPath("//*[@id=\"Message-Message\"]"));
            msgTextBox.SendKeys("Hello World");

            System.Threading.Thread.Sleep(3000);

            IWebElement submitButton = driver.FindElement(By.XPath("//*[@id=\"wf-form-Quote-Request\"]/input[4]"));
            submitButton.Click();

            System.Threading.Thread.Sleep(3000);

            // Assert that the title contains the keyword "Selenium"
            if (driver.Title.Contains("Thank You"))
            {
                Console.WriteLine("Test Passed!");
            }
            else
            {
                Console.WriteLine("Test Failed!");
            }


            // Close the browser
            driver.Quit();
        }

    }
}
