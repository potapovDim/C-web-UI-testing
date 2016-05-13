using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
namespace ConsoleApplication4
{
    class SeleniumMethods
    {
        //custom method for enter text 
        public static void EnterText(IWebDriver driver, string elementType,string elementValue, string textValue)
        {   
             if (elementType == "Id")
                 driver.FindElement(By.Id(elementValue)).SendKeys(textValue);
            else if (elementType == "Name")
                 driver.FindElement(By.Name(elementValue)).SendKeys(textValue);
        }
        //custom method for click
        public static void ClickElement(IWebDriver driver,string elementType,string elementValue)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(elementValue)).Click();
            }
            else if (elementType == "Name")
                driver.FindElement(By.Name(elementValue)).Click();
        }
        public static void SelectDDL(IWebDriver driver,string element,string elementType,string elementValue)
        {

            if (elementType == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(elementValue);
            }
            else if (elementType == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(elementValue);
        }

    }
}
