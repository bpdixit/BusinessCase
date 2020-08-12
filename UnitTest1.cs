using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BdixitTest
{
    [TestClass]
    public class Ingenco_Test
    {
        [TestMethod]
        public void Login_name_atlphanumeric()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://secure.ogone.com/Ncol/Prod/Backoffice/AccountCreation/Create");

            //Now finding form elements to auto fill the form page
            //1. Autofill the "Choose your login name (PSPID)"

            IWebElement login_name = driver.FindElement(By.Id("txt_PspId"));
            login_name.SendKeys("Bhanupriya@");
            login_name.SendKeys(Keys.Enter);
            string warning_alphanumeric = driver.FindElement(By.ClassName("field-validation-error")).Text;
            Assert.IsTrue(warning_alphanumeric.Contains("Only alphanumeric characters are allowed."));
            driver.Quit();
        }

        [TestMethod]
        public void Email_id_validation()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://secure.ogone.com/Ncol/Prod/Backoffice/AccountCreation/Create");

            //Now finding form elements to auto fill the form page
            //2. Autofill the "Choose your email ID"

            IWebElement email_id = driver.FindElement(By.Id("txt_Email"));
            email_id.SendKeys("Bhanupriya");
            email_id.SendKeys(Keys.Enter);
            string warning_invalid_id = driver.FindElement(By.CssSelector("#div-page > div:nth-child(3) > div.grid-8 > div > span > p")).Text;
            Assert.IsTrue(warning_invalid_id.Contains("Your e-mail address is invalid."));
            driver.Quit();
        }

        [TestMethod]
        public void phone_number_validation()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://secure.ogone.com/Ncol/Prod/Backoffice/AccountCreation/Create");

            //Now finding form elements to auto fill the form page
            //3. Autofill the "phone number"

            IWebElement phone_number = driver.FindElement(By.Id("txt_PhoneNo"));
            phone_number.SendKeys("abcd");
            phone_number.SendKeys(Keys.Enter);
            string phone_invalid = driver.FindElement(By.CssSelector("#div-page > div:nth-child(9) > div.grid-8 > div > span > p")).Text;
            Assert.IsTrue(phone_invalid.Contains("Only numeric characters and special characters"));
            driver.Quit();

        
        }
    }
}
