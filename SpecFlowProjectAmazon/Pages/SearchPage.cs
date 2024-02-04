using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectAmazon.Pages
{
    public class SearchPage:WebInit
    {
        private IWebDriver Driver;
        public SearchPage(IAmazonDriver driver):base(driver)
        { 
        
        
        }


        //Web Elements
        public String SearchBar = "twotabsearchtextbox";
        public String SearchResultText = "//div[@cel_widget_id='UPPER-RESULT_INFO_BAR-0']/h1/div/div/div/div/span[contains(text(),'results')]/following::span/following::span[contains(text(),'{0}')] and [contains(@class,'a-color-state a-text-bold')]";
        public String SelectProductLink = "(//a[contains(@class,'underline')]/parent::h2)[1]";
        public String AddToCartButtonOnProductPage = "add-to-cart-button";
        public String CartIconOnProductPage = "nav-cart";
        public String CartItemInCartPage = "//span[@class='a-list-item']/a/span/span/span[contains(@class,'a-truncate-full a-offscreen')]";
        public String CompanyLogoTextID = "nav-logo-sprites";




        public void NavigateToAmazon()
        {
            Driver.Navigate().GoToUrl("https://www.amazon.com/");
            
        }

        public void SearchProduct(string ProductName)
        {
            Driver.FindElement(By.Id(SearchBar)).SendKeys(ProductName);
        }

        public string SearchResultTextInResultInfo(string ProductName)
        {
            string SearchResult = Driver.FindElement(By.XPath(String.Format(SearchResultText,ProductName))).Text;
            return SearchResult;
        }

        public void ClickOnSelectedProductLink()
        {
            Driver.FindElement(By.XPath(SelectProductLink)).Click();
        }

        public void ClickOnAddToCartButtonOnproductPage()
        {
            Driver.FindElement(By.XPath(AddToCartButtonOnProductPage)).Click();
        }

        public void ClickOnCartIconOnProductPage()
        {
            Driver.FindElement(By.Id(CartIconOnProductPage)).Click();
        }

        public Boolean ItemInCartTextValidation(string productName)
        {
            string ItemInCartTextOnUI = Driver.FindElement(By.XPath(CartItemInCartPage)).GetAttribute("text");
            if(ItemInCartTextOnUI.Contains(productName))
            {
                return true;
            }
            return false;

        }

        public String VerifyCompanyLogo(string CompanyLogoName)
        {
            String LogoTextOnUI = Driver.FindElement(By.Id(CompanyLogoTextID)).Text;
            return LogoTextOnUI;
        }







    }
}
