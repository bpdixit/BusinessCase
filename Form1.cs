using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BDixit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://secure.ogone.com/Ncol/Prod/Backoffice/AccountCreation/Create");


            //Now finding form elements to auto fill the form page
            //1. Autofill the "Choose your login name (PSPID)"

            var login_name = driver.FindElementByCssSelector("#txt_PspId");
            if (login_name != null)
            {
                //Now we perform actions on this element

                Actions actions = new Actions(driver);
                actions.MoveToElement(login_name);
                actions.Click();
                actions.SendKeys("BhanupriyaDixit");
                actions.Build().Perform();

                //2. Autofill the "E-mail address"

                var email_address = driver.FindElementByCssSelector("#txt_Email");
                if (email_address != null)
                {
                    //Now we perform actions on this element

                    Actions action1 = new Actions(driver);
                    action1.MoveToElement(email_address);
                    action1.Click();
                    action1.SendKeys("Bhanupriya@gmail.com");
                    action1.Build().Perform();

                }

                //3. Autofill the "Company name"

                var company_name = driver.FindElementByCssSelector("#txt_CompanyName");
                if (company_name != null)
                {
                    //Now we perform actions on this element

                    Actions action2 = new Actions(driver);
                    action2.MoveToElement(company_name);
                    action2.Click();
                    action2.SendKeys("Ingenico");
                    action2.Build().Perform();

                }

                //4. Autofill the "Contact person"

                var contact_person = driver.FindElementByCssSelector("#txt_ContactPerson");
                if (contact_person != null)
                {
                    //Now we perform actions on this element

                    Actions action3 = new Actions(driver);
                    action3.MoveToElement(contact_person);
                    action3.Click();
                    action3.SendKeys("Ingenico");
                    action3.Build().Perform();

                }

                //5. Autofill the "Phone number"

                var phone_number = driver.FindElementByCssSelector("#txt_PhoneNo");
                if (phone_number != null)
                {
                    //Now we perform actions on this element

                    Actions action4 = new Actions(driver);
                    action4.MoveToElement(phone_number);
                    action4.Click();
                    action4.SendKeys("123456789");
                    action4.Build().Perform();

                }

                //6. Autofill the "Website address"

                var web_address = driver.FindElementByCssSelector("#txt_Website");
                if (web_address != null)
                {
                    //Now we perform actions on this element

                    Actions action5 = new Actions(driver);
                    action5.MoveToElement(web_address);
                    action5.Click();
                    action5.SendKeys("www.ingneico.com");
                    action5.Build().Perform();

                }

                //7. Autofill the "Choose your product"

                var product_name = driver.FindElementByCssSelector("#ddl_ProductMode");
                if (product_name != null)
                {
                    //Now we perform actions on this element

                    Actions action6 = new Actions(driver);
                    action6.MoveToElement(product_name);
                    action6.Click();
                    action6.SendKeys("DirectLink");
                    action6.Click();
                    action6.Build().Perform();

                }

                //8. Autofill the "Status of VAT number"

                var vat_status = driver.FindElementByCssSelector("#ddl_VATStatus");
                if (vat_status != null)
                {
                    //Now we perform actions on this element

                    Actions action7 = new Actions(driver);
                    action7.MoveToElement(vat_status);
                    action7.Click();
                    action7.SendKeys("N");
                    action7.Click();
                    action7.Build().Perform();

                }

                //9. Autofill the "VAT number"

                var vat_number = driver.FindElementByCssSelector("#txt_VATNo");
                if (vat_number != null)
                {
                    //Now we perform actions on this element

                    Actions action8 = new Actions(driver);
                    action8.MoveToElement(vat_number);
                    action8.Click();
                    action8.SendKeys("123456789");
                    action8.Build().Perform();

                }

                //10. Autofill the "Payment processing dates"

                var payment_dates = driver.FindElementByCssSelector("#ddl_EstimatedTransactionStart");
                if (payment_dates != null)
                {
                    //Now we perform actions on this element

                    Actions action9 = new Actions(driver);
                    action9.MoveToElement(payment_dates);
                    action9.Click();
                    action9.SendKeys("n");
                    action9.Click();
                    action9.Build().Perform();

                }

                //11. Autofill the "Estimated monthly transaction volume"

                var trans_volume = driver.FindElementByCssSelector("#ddl_EstimatedTransactionVolume");
                if (trans_volume != null)
                {
                    //Now we perform actions on this element

                    Actions action10 = new Actions(driver);
                    action10.MoveToElement(trans_volume);
                    action10.Click();;
                    action10.SendKeys("0");
                    action10.Click();
                    action10.Build().Perform();

                }

                //12. Autofill the "Integration achieved by Ingenico"

                var ingenco_integrated = driver.FindElementByCssSelector("#ddl_SolutionProvider");
                if (ingenco_integrated != null)
                {
                    //Now we perform actions on this element

                    Actions action11 = new Actions(driver);
                    action11.MoveToElement(ingenco_integrated);
                    action11.Click();
                    action11.Click();
                    action11.Build().Perform();

                }

                //13. Autofill the "Country"

                var country_name = driver.FindElementByCssSelector("#ddl_CountryDetail");
                if (country_name != null)
                {
                    //Now we perform actions on this element

                    Actions action12 = new Actions(driver);
                    action12.MoveToElement(country_name);
                    action12.Click();
                    action12.SendKeys("france");
                    action12.Click();
                    action12.Build().Perform();

                }

                //14. Autofill the "Checkbox"

                var checkbox = driver.FindElementByCssSelector("#chk_GeneralCondition");
                if (checkbox != null)
                {
                    //Now we perform actions on this element

                    Actions action13 = new Actions(driver);
                    action13.MoveToElement(checkbox);
                    action13.Click();
                    action13.Build().Perform();

                }

                //15. Autofill the "Register"

                var register = driver.FindElementByCssSelector("#btn_Register > span.innerSpan");
                if (register != null)
                {
                    //Now we perform actions on this element

                    Actions action14 = new Actions(driver);
                    action14.MoveToElement(register);
                    action14.Click();
                    action14.Build().Perform();

                }




            }
        }
    }
}
