using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Automation_task.Page_Object
{
    public class Main_Page : Base_Page
    {
        public Main_Page(IWebDriver driver) : base(driver)
        {
        }
        public override string PageUrl => "https://testpages.herokuapp.com/styled/basic-html-form-test.html";

        public IWebElement username => driver.FindElement(By.CssSelector("input[name='username']"));
        public IWebElement password => driver.FindElement(By.CssSelector("input[name='password']"));
        public IWebElement textArea => driver.FindElement(By.Name("comments"));
        public IWebElement checkBox1 => driver.FindElement(By.CssSelector("input[value='cb1']"));
        public IWebElement checkBox2 => driver.FindElement(By.CssSelector("input[value='cb2']"));
        public IWebElement checkBox3 => driver.FindElement(By.CssSelector("input[value='cb3']"));
        public IWebElement radioButton1 => driver.FindElement(By.XPath("//input[@value='rd1']"));
        public IWebElement radioButton2 => driver.FindElement(By.XPath("//input[@value='rd2']"));
        public IWebElement radioButton3 => driver.FindElement(By.XPath("//input[@value='rd3']"));
        public IWebElement submitButton => driver.FindElement(By.CssSelector("input[value='submit']"));

      
        String name = "randomName";
        String pass = "randomPassword";
        String comment = "this comment is random";

        public void check_checkBoxes()
        {
            if (checkBox1.GetAttribute("checked")=="true")
            {
                
            }
            else 
            {
                checkBox1.Click();
            }
            if (checkBox2.GetAttribute("checked") == "true")
            {

            }
            else
            {
                checkBox2.Click();
            }
            if (checkBox3.GetAttribute("checked") == "true")
            {

            }
            else
            {
                checkBox3.Click();
            }
        }
        public void check_radioButtons()
        {
            if (radioButton3.GetAttribute("checked") == "true")
            {

            }
            else
            {
                radioButton3.Click();
            }
            
        }
        
        public void select_dropDown()
        {
            SelectElement select = new SelectElement(driver.FindElement(By.Name("dropdown")));
            select.SelectByValue("dd5");
        }
        public void filling_out_the_form()
        {
            username.SendKeys(name);
            password.SendKeys(pass);
            textArea.Clear();
            textArea.SendKeys(comment);
            check_checkBoxes();
            check_radioButtons();
            select_dropDown();
        }
    }
}
