using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement element;
    static void Main()
    {
        string url = "http://testing.todorvachev.com/special-elements/check-button-test-3/";
        string option = "2";
        driver.Navigate().GoToUrl(url);
        element = driver.FindElement(By.XPath("//*[@id=\"post-33\"]/div/p[6]/input[" + option + "]"));
        //element.SendKeys(Keys.Space);
        //Thread.Sleep(4000);
        bool isChecked = bool.TryParse(element.GetAttribute("checked"), out isChecked);

        if (isChecked)
        {
            Console.WriteLine("This checkbox is already checked!");
        }
        else
        {
            Console.WriteLine("Huh, someone left the checkbox unchecked, lets check it!");

            element.Click();
        }
        driver.Quit();
    }
}