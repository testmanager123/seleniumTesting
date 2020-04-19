using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    class Program
    {

        static void Main(string[] args)
        {
            ///create browser instance 
            IWebDriver myDriver = new ChromeDriver(@"C:\\Users\\Srinivas\\Desktop\\EclipseNew");
            ///open test app 
            myDriver.Navigate().GoToUrl("http://www.facebook.com");
            Console.WriteLine("app displayed");
            ///maxiize the app
            myDriver.Manage().Window.Maximize();
            Console.WriteLine("this is maximized");

            ///identify the first name
            IWebElement fname = myDriver.FindElement(By.Name("firstname"));
            ///first name exist or not
            if((fname.Displayed)==true)
            {
                Console.WriteLine("first name displayed");
            }
            else
            {
                Console.WriteLine("first name not displayed");
            }
            //first name enabled or not
            if((fname.Enabled)==true)
            {
                Console.WriteLine("firstname enabled");
            }
            else
            {
                Console.WriteLine("fisrt name not enabled");
            }
            ////enter  data
            fname.SendKeys("tester");

            ///capture data from edit box  
            String myFname = fname.GetAttribute("value");
            Console.WriteLine(myFname);
            ////count of input category
            int inputCount = myDriver.FindElements(By.XPath("//input")).Count;
            Console.WriteLine("no of inputs are  :  " + inputCount);

            int inputCount2 = myDriver.FindElements(By.TagName("input")).Count;
            Console.WriteLine("no of inputs are  :  " + inputCount2);




            System.Threading.Thread.Sleep(10000);
            myDriver.Close();
            myDriver.Quit();

        }
        
    }
}
