using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectAmazon
{
    public class WebInit
    {
        private IAmazonDriver Driver { get; set; }

        ChromeDriver chromedriver;

        protected WebInit(IAmazonDriver driver) 
        {
            Driver = driver; 
        }

        [BeforeScenario]
        public void BeforeScenario() 
        {
          
            chromedriver = new ChromeDriver();



        }








    }
}
