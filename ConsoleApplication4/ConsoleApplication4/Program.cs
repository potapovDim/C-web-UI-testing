using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    
    class Program
    {
        static void Main() { }
        IWebDriver driver = new ChromeDriver();
    
        [SetUp]
     public void Initialz()
     {
         driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
     }

        [Test]
        public void ExecuteTest()
        {   /*
             * This is test 
             * here u use methods for parts of web UI
             * for example textbox,buttons,links etx
             */
            SeleniumMethods.EnterText(driver, "Name", "UserName", "Delano0");
            SeleniumMethods.EnterText(driver, "Name", "Password", "78217tc");
            SeleniumMethods.ClickElement(driver, "Name", "Login");
            SeleniumMethods.EnterText(driver, "Id", "Initial", "Dell");
            SeleniumMethods.SelectDDL(driver, "TitleId", "Id", "Mr");
            SeleniumMethods.EnterText(driver,"Id","FirstName","Delanop0");
            SeleniumMethods.ClickElement(driver, "Name", "Hindi");
        }
        [TearDown]
        public void CleanUp()
        {   //closer driver
            driver.Close();
        }
    }
}
