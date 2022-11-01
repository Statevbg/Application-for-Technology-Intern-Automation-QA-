using Automation_task.Page_Object;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Automation_task.Test
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
        }
        [TearDown]
        public void ShutDown()
        {
            driver.Quit();
        }
       
        [Test]
        public void TestingSubmitForm()
        {
            //Arrange
            var main_page = new Main_Page(driver); 
            //Act
            main_page.Open();
            main_page.filling_out_the_form();

        }
    }
}
