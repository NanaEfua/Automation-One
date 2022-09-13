using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestingGroupJ.Utilities;

namespace TestingGroupJ.PageObject
{
    class RegistrationPage
    {
       public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement SignUp => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a"));
        IWebElement Username => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));
        IWebElement Email => driver.FindElement(By.XPath("/html / body / div / div / div / div / div / div / form / fieldset / fieldset[2] / input"));
        IWebElement Password => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));
        IWebElement SignUpButton => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > button"));
        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));
       
        

        public void ClickOnSignUp()
        {
            SignUp.Click();
        }

        public void EnterUsername()
        {
            //Random randomGenerator = new Random();
            //int randomInt = randomGenerator.Next(1000);
            //Username.SendKeys("EfuaBo" + randomInt);
            Username.SendKeys("EfuaBo");
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }

        public void EnterEmail()
        {
            //Random randomGenerator = new Random();
            //int randomInt = randomGenerator.Next(1000);
            //Email.SendKeys("nana" + randomInt + "@yahoo.com");
            Email.SendKeys("nana@yahoo.com");
        }
    
        public void EnterPassword()
        {
            Password.SendKeys("1234");
        }
    
        public void ClickOnSignUpButton()
        {
            SignUpButton.Click();
        }

        public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }





    }
}
