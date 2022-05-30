using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace May2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //open chrome Browser
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();



            //launch turn up portal

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //identify username textbox and enter valid user name

            IWebElement usertextbox = driver.FindElement(By.Id("UserName"));

            usertextbox.SendKeys("hari");

            //identify password textbox and enter valid password

            IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));

            passwordtextbox.SendKeys("123123");


            //identify login button and click login button
            IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));

            loginbutton.Click();

            //checked if user has logged in successfully


            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));


           if(hellohari.Text == "Hello hari!"){

                Console.WriteLine("login successfull");
            }

            else
            {
                Console.WriteLine("login failed");

            }

            //Thread.Sleep(30000);

        }
    }
}
