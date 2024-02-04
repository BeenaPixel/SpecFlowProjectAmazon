using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectAmazon
{

    public class WebUISteps : IAmazonDriver
    {
        private IWebDriver Driver;

        public WebUISteps(IWebDriver driver)
        {
            Driver = driver;
        }

        public IAmazonDriver Write(By by, string text)
        {
            if(!string.IsNullOrEmpty(text))
            {
                Driver.FindElement(by).SendKeys(text);
            }
            return this;
        }
    }
}
