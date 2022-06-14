using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace May2022
{
    class Program
    {
        private static object administrationtab;
        private static object codeTextbox;

        static void Main(string[] args)
        {
           /// TO Begin  
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

            // Create Material Record

            //find administration drop down button
            //IWebElement administration = driver . FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            
             
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();

            // select time & material from list
            IWebElement timematerial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timematerial.Click();

            //click on creat New button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            //select material from type code list
            
            IWebElement typedropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            
            typedropdown.Click();

            // click material option from drop down list
            IWebElement materialoption = driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));

          


            materialoption.Click();

            //enter the code in code textbox
            IWebElement code = driver.FindElement(By.XPath("//*[@id='Code']"));

            code.SendKeys("1234");

            //enter the description into the descrprition textbox
            IWebElement description = driver.FindElement(By.XPath("//*[@id='Description']"));
            description.SendKeys("mytest");


            /// //*[@id="TimeMaterialEditForm"]/div/div[4]/div/span[1]/span/input[1]
            IWebElement priceClick = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));

            priceClick.Click();

            /// //*[@id="Price"]


            //enter price per unit into the price per unit textbox
            IWebElement priceperunit = driver.FindElement(By.XPath("//*[@id='Price']"));

             
             priceperunit.SendKeys("100");


            //click save button
            

            IWebElement savebutton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
                

            savebutton.Click();

            Thread.Sleep(1500);

            // click the last page button


            IWebElement lastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));

            lastpagebutton.Click();
            Thread.Sleep(3000);

            //check the material created


            IWebElement lastrec = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (lastrec.Text == "1234")
            {
                Console.WriteLine("New record creat succesfully");
            }

            else
            {
                Console.WriteLine("New record unsuccess");

            }

            Thread.Sleep(5000);

            /// The Program end .Write before this 






            //Creat Time Record


            //find administration dropdown button

            IWebElement adminisstration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            adminisstration.Click();


            // select Time & material from list
            IWebElement time = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
           
            //click on creat New button
            IWebElement creatnewbutton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            creatnewbutton.Click();

            // select time from type code list
            IWebElement typecode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            typecode.Click();


            // click Time option from drop down list
            IWebElement Time = driver .FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            time.SendKeys();

            //enter code option from code element
            IWebElement Code = driver.FindElement(By.XPath("//*[@id='Code']"));
            code . SendKeys();

            //enter the description into the descrprition textbox
            IWebElement Description = driver.FindElement(By.XPath("//*[@id='Description']"));
             description.SendKeys();

            //enter price per unit into the price per unit textbox
            IWebElement pricePerUnit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")); ;
            priceperunit.SendKeys();

            //click save button
            IWebElement Save = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            Save.Click();

            // click the last page button
            IWebElement Lastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span));
            lastpagebutton.Click();

            //check the Time created
            IWebElement lastrecord = driver.FindElement("//*[@id='tmsGrid']/div[3]/table/tbody/tr[9]");

            // The Program end .Write before this 


        }


    }
}
