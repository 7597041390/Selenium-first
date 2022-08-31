using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
namespace Selenium_first
{
    internal class Program
    {       
        static void Main(string[] args)
        {
                   
            Program p1 = new Program();
            p1.Attachto();
            Console.Read();

        }
        public void CreateCard()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.Flocard.app");
            driver.Manage().Window.Maximize();
            //driver.FindElement(By.LinkText("Create FloCard")).Click();
            driver.FindElement(By.XPath("//a[@href='/Login']")).Click();
            //System.Threading.Thread.Sleep(15000);
            driver.FindElement(By.XPath("//img[@src='/img/linkedin-social-media-logo-7.png']")).Click();
            driver.FindElement(By.XPath("//input[@id='username']")).SendKeys("tripathirahul773@gmail.com");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Bholu@123");
            //System.Threading.Thread.Sleep(15000);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.FindElement(By.XPath("//div[@id='new_card_id']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtHeadline']")).SendKeys("intern");
            driver.FindElement(By.XPath("//input[@id='txtPhone']")).SendKeys("7597041390");

            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//input[@class='btn btn-primary ml-4']")).Click();
            driver.FindElement(By.XPath("//button[@id='btnConfirmYes']")).Click();


        }
        public void Edit()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.Flocard.app");
            driver.Manage().Window.Maximize();
            //driver.FindElement(By.LinkText("Create FloCard")).Click();
            driver.FindElement(By.XPath("//a[@href='/Login']")).Click();
            //System.Threading.Thread.Sleep(15000);
            driver.FindElement(By.XPath("//img[@src='/img/linkedin-social-media-logo-7.png']")).Click();
            driver.FindElement(By.XPath("//input[@id='username']")).SendKeys("tripathirahul773@gmail.com");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Bholu@123");
            //System.Threading.Thread.Sleep(15000);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.FindElement(By.XPath("//i[@id='editIntro']")).Click();
            driver.FindElement(By.XPath("//a[@class='dropdown-item dropDownHide ']")).Click();
            driver.FindElement(By.XPath("//input[@id='txtHeadline']")).SendKeys("Student");
            driver.FindElement(By.XPath("//input[@id='txtPhone']")).SendKeys("7597041390");


            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            System.Threading.Thread.Sleep(10000);
            driver.FindElement(By.XPath("//button[@id='btnConfirmYes']")).Click();
            driver.FindElement(By.XPath("//span[@class='toggle-switch-indicator']")).Click();
            driver.FindElement(By.XPath("//button[@id='btnUpdate']")).Click();
            
        }
        public void Exchangecard()
        {
            IWebDriver driver = new ChromeDriver();
            driver.FindElement(By.XPath("//i[@id='editIntro']")).Click();

            driver.FindElement(By.LinkText("Exchange Card")).Click();
            driver.FindElement(By.XPath("//a[@id='genOtp']")).Click();
        } 
        public void setasdefaultcard()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.Flocard.app");
            driver.Manage().Window.Maximize();
            //driver.FindElement(By.LinkText("Create FloCard")).Click();
            driver.FindElement(By.XPath("//a[@href='/Login']")).Click();
            //System.Threading.Thread.Sleep(15000);
            driver.FindElement(By.XPath("//img[@src='/img/linkedin-social-media-logo-7.png']")).Click();
            driver.FindElement(By.XPath("//input[@id='username']")).SendKeys("tripathirahul773@gmail.com");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Bholu@123");
            //System.Threading.Thread.Sleep(15000);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("//i[@id='editIntro']")).Click();
            driver.FindElement(By.XPath("//a[@id='def1']")).Click();

        }
        public void ShareCard()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.Flocard.app");
            driver.Manage().Window.Maximize();
            //driver.FindElement(By.LinkText("Create FloCard")).Click();
            driver.FindElement(By.XPath("//a[@href='/Login']")).Click();
            //System.Threading.Thread.Sleep(15000);
            driver.FindElement(By.XPath("//img[@src='/img/linkedin-social-media-logo-7.png']")).Click();
            driver.FindElement(By.XPath("//input[@id='username']")).SendKeys("tripathirahul773@gmail.com");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Bholu@123");
            //System.Threading.Thread.Sleep(15000);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.FindElement(By.XPath("//i[@id='editIntro']")).Click();
            driver.FindElement(By.LinkText("Share Card")).Click();
            driver.FindElement(By.XPath("//a[@id='action-button']")).Click();
        }
        public void Attachto()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.Flocard.app");
            driver.Manage().Window.Maximize();
            //driver.FindElement(By.LinkText("Create FloCard")).Click();
            driver.FindElement(By.XPath("//a[@href='/Login']")).Click();
            //System.Threading.Thread.Sleep(15000);
            driver.FindElement(By.XPath("//img[@src='/img/linkedin-social-media-logo-7.png']")).Click();
            driver.FindElement(By.XPath("//input[@id='username']")).SendKeys("tripathirahul773@gmail.com");
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Bholu@123");
            //System.Threading.Thread.Sleep(15000);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.FindElement(By.XPath("//i[@id='editIntro']")).Click();
            driver.FindElement(By.LinkText("Attach to Organization")).Click();
            driver.FindElement(By.XPath("//button[@id='btnSubmit']")).Click();
            System.Threading.Thread.Sleep(15000);
            driver.FindElement(By.XPath("//input[@type='email']")).SendKeys("tripathirahul773@gmail.com");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
           // driver.FindElement(By.XPath("//a[@id='idA_PWD_SwitchToPassword']")).Click();
            driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Rah@123hul");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            
        }
        public void contactUs()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.Flocard.app");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.LinkText("Contact Us")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("Rahul");
            driver.FindElement(By.Id("lastName")).SendKeys("Tripathi");
            driver.FindElement(By.Id("emailAddress")).SendKeys("tripathirahul773@gmail.com");
            driver.FindElement(By.Id("message")).SendKeys("I would like to thank Flocard");
            System.Threading.Thread.Sleep(15000);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }
       
    }

    
    
    
}
