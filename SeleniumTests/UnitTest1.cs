using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests {
    [TestClass]
    public class ChromeTests {
        ChromeDriver driver;
        [TestInitialize]
        public void Initialize() {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://certicon-testing.azurewebsites.net");
            IWebElement messagesLink = driver.FindElement(By.LinkText("Messages"));
            messagesLink.Click();
        }
        [TestMethod]
        public void EverythingOk() {
            EnterTheName("Hulmiho");
            EnterTheEmail("hulmiho@ukolen.com");
            EnterTheMessage("Joha joha joha");
            ClickTheCreateButton();
            Assert.AreEqual("You have 1 messages", driver.FindElement(By.Id("messageNumber")).Text);
        }
        
        public void EnterTheName(string name) {
            driver.FindElement(By.Id("Name")).SendKeys(name);

        }

        public void EnterTheEmail(string email) {
            driver.FindElement(By.Id("Email")).SendKeys(email);

        }

        public void EnterTheMessage(string message) {
            driver.FindElement(By.Id("Content")).SendKeys(message);

        }

        private void ClickTheCreateButton() {
            driver.FindElement(By.Id("buttonCreate")).Click();
        }

        [TestMethod]
        public void ForgetToEnterContent() {
            EnterTheName("Hulmiho");
            EnterTheEmail("hulmiho@ukolen.com");
            ClickTheCreateButton();
            Assert.AreEqual("Message Content is Required", driver.FindElement(By.ClassName("validation-summary-errors")).Text);
        }

        [TestCleanup]
        public void Cleanup() {
            driver.Close();
        }
    }
}