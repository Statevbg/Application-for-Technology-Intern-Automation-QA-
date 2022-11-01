using OpenQA.Selenium;

namespace Automation_task.Page_Object
{
    public class Base_Page
    {
        protected readonly IWebDriver driver;
        public virtual string PageUrl { get; }

        public Base_Page(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void Open()
        {
            driver.Navigate().GoToUrl(this.PageUrl);
        }
    }
}
