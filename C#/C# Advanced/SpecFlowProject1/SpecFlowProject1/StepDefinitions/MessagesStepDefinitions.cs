using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions {
    [Binding]
    public class MessagesStepDefinitions {
        IWebDriver? driver;
        IWebElement? LinkMessages;
        IWebElement? tbEmail;
        IWebElement? tbName;
        IWebElement? tbContent;
        IWebElement? buttonCreate;
        IWebElement? successInfoLabel;
        IWebElement? messageNumberLabel;

        [BeforeScenario]
        public void Before() {

            driver = new ChromeDriver();
        }


        [Given(@"I have opened the website")]
        public void GivenIHaveOpenedTheWebsite() {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://certicon-testing.azurewebsites.net");
            LinkMessages = driver.FindElement(By.LinkText("Messages"));
            LinkMessages.Click();
        }

        [Given(@"I have entered a name")]
        public void GivenIHaveEnteredAName() {
            tbName = driver.FindElement(By.Id("Name"));
            tbName.SendKeys("Fero Lakatos");
        }

        [Given(@"I have entered a correct email")]
        public void GivenIHaveEnteredACorrectEmail() {
            tbEmail = driver.FindElement(By.Id("Email"));
            tbEmail.SendKeys("FeroLakatos@seznam.cz");
        }

        [Given(@"I have entered some message")]
        public void GivenIHaveEnteredSomeMessage() {
            tbContent = driver.FindElement(By.Id("Content"));
            tbContent.SendKeys("Ahoj, nazdar kamaráde!");
        }

        [When(@"I click The Create button")]
        public void WhenIClickTheCreateButton() {
            buttonCreate = driver.FindElement(By.Id("buttonCreate"));
            buttonCreate.Click();
        }

        [Then(@"the succes message should be displayed")]
        public void ThenTheSuccesMessageShouldBeDisplayed() {
            successInfoLabel = driver.FindElement(By.Id("success"));
            Assert.AreEqual("The message has been saved", successInfoLabel.Text);
            messageNumberLabel = driver.FindElement(By.Id("messageNumber"));
            Assert.AreEqual("You have 1 messages", messageNumberLabel.Text);
        }

        [AfterScenario]
        public void CleanUp() {
            //driver.Close();

        }
    }
}
