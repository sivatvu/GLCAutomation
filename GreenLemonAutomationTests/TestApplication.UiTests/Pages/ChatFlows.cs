using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.UiTests.Pages
{
    public class ChatFlows
    {

        private readonly IWebDriver _driver;



        [FindsBy(How = How.XPath, Using = "//*[@href='/MCP_Web/Entry_Goals.aspx']")]
        protected IWebElement ClickChatFlows { get; set; }



        [FindsBy(How = How.XPath, Using = "//input[@type='submit'and @value='Actions' ]")]
        protected IWebElement ActionsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit'and @value='Goals' ]")]
        protected IWebElement GoalsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Improve credit score')]")]
        protected IWebElement ImproveCreditScore { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='ChatFlow.aspx?ChatFlowId=4&(Not.Licensed.For.Production)=']")]
        protected IWebElement BuyaCar { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='Card']")]
        protected IWebElement ChatCard { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'do it!')]")]
        protected IWebElement StartChat { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'put a key in the ignition and get started.')]")]
        protected IWebElement putakey { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='fa fa-4x fa-key OSInline']")]
        protected IWebElement key { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Did you know the average running cost of a car is ')]")]
        protected IWebElement verifyrunningcost { get; set; }


        [FindsBy(How = How.XPath, Using = "//span[text()='Restart plan']")]
        protected IWebElement RestartPlan { get; set; }



        public ChatFlows(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }





        public void ClickChat()
        {

            ClickChatFlows.Click();
        }

        

        public void GoalandActions()
        {

             Assert.IsTrue(ActionsButton.Displayed);
            Assert.IsTrue(GoalsButton.Displayed);
            //Assert.IsTrue(Ukcredit.Displayed);

        }


        public void ClickActions()
        {

            ActionsButton.Click();
        }

        public void ActionsPage()
        {

            Assert.IsTrue(ImproveCreditScore.Displayed);
            
        }

        public void ClickGoals()
        {

            GoalsButton.Click();
        }

        public void ChatCar()
        {

            Assert.IsTrue(BuyaCar.Displayed);

        }

        public void ClickBuyaCarChat()
        {

            BuyaCar.Click();

        }

        public void Chatbox()
        {

            Assert.IsTrue(ChatCard.Displayed);
            System.Threading.Thread.Sleep(20000);


        }

        public void StarttheChat()
        {

            StartChat.Click();
            System.Threading.Thread.Sleep(20000);

        }

        public void responce()
        {

            putakey.Click();
            System.Threading.Thread.Sleep(20000);

        }

        public void Clickonthekey()
        {

            key.Click();
            System.Threading.Thread.Sleep(20000);

        }


        public void Verifythechat()
        {

            Assert.IsTrue(verifyrunningcost.Displayed);
            System.Threading.Thread.Sleep(20000);

        }

        public void ClickRestartplan()
        {

            RestartPlan.Click();
            System.Threading.Thread.Sleep(1000);

        }


    }
}
