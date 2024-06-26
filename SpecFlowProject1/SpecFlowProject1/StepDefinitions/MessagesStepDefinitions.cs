using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class MessagesStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I open the website")]
        public void GivenIOpenTheWebsite()
        {
            driver.Navigate().GoToUrl("https://certicon-testing.azurewebsites.net/");
        }

        [Given(@"I click the Messages link")]
        public void GivenIClickTheMessagesLink()
        {
            driver.FindElement(By.LinkText("Messages")).Click();
        }

        [When(@"I enter the name ""(.*)""")]
        public void WhenIEnterTheName(string name)
        {
            driver.FindElement(By.Id("Name")).SendKeys(name);
        }

        [When(@"I enter the email ""(.*)""")]
        public void WhenIEnterTheEmail(string email)
        {
            driver.FindElement(By.Id("Email")).SendKeys(email);
        }

        [When(@"I enter the message ""(.*)""")]
        public void WhenIEnterTheMessage(string message)
        {
            driver.FindElement(By.Id("Content")).SendKeys(message);

        }

        [When(@"I click the Create button")]
        public void WhenIClickOnTheCreateButton()
        {
            driver.FindElement(By.Id("buttonCreate")).Click();
        }

        [Then(@"my message should be displayed")]
        public void ThenMyMessageShouldBeDisplayed()
        {
            Assert.AreEqual("You have 1 messages", driver.FindElement(By.Id("messageNumber")).Text);
        }

        [Then(@"I can close the browser window")]
        public void ThenICanCloseTheBrowserWindow() {
            driver.Close();
        }

        [When(@"I forgot to enter the email")]
        public void WhenIForgotToEnterTheEmail() {
            driver.FindElement(By.Id("Email")).Click();
        }

        [Then(@"the error messages shows")]
        public void ThenTheErrorMessagesShows() {
            Assert.AreEqual("Email is Required", driver.FindElement(By.ClassName("validation-summary-errors")).Text);
        }

    }
}
