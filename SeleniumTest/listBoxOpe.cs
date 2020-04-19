using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    class listBoxOpe
    {
        static void Main(string[] args)
        {
            ///create browser instance 
            IWebDriver myApp = new ChromeDriver(@"C:\\Users\\Srinivas\\Desktop\\EclipseNew");
            ///open app
            myApp.Navigate().GoToUrl("http://www.facebook.com");

            /////maximize
            myApp.Manage().Window.Maximize();
            ///identify month list box 
            IWebElement myMonth = myApp.FindElement(By.Id("month"));

        }
    }
}
