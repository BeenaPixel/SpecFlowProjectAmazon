using SpecFlowProjectAmazon.Pages;
using System;
using TechTalk.SpecFlow;

using NUnit.Framework;

namespace SpecFlowProjectAmazon.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions:WebInit
    {
        public SearchStepDefinitions(IAmazonDriver driver):base(driver) { }

        public SearchPage SearchPage;

        

        [Given(@"User Navigates to Amazon")]
        public void GivenUserNavigatesToAmazon()
        {
            SearchPage.NavigateToAmazon();
        }

        [When(@"User search with Product Name (.*)")]
        public void WhenUserSearchWithProductName(string productName)
        {
            SearchPage.SearchProduct(productName);
        }

        [Then(@"Verify the Search item with the Product Name (.*)")]
        public void ThenVerifyTheSearchItemWithTheProductName(string productName)
        {
            String ResultTextOnUI=SearchPage.SearchResultTextInResultInfo(productName);
            Assert.AreEqual(ResultTextOnUI,productName,"Items Does not match with Search Item");
        }

        [When(@"User selects the Product")]
        public void WhenUserSelectsTheProduct()
        {
            SearchPage.ClickOnSelectedProductLink();
        }

        [When(@"Clicks on Add to Cart Button")]
        public void WhenClicksOnAddToCartButton()
        {
            SearchPage.ClickOnAddToCartButtonOnproductPage();
        }

        [When(@"Navigate to Cart")]
        public void WhenNavigateToCart()
        {
            SearchPage.ClickOnCartIconOnProductPage();  
        }

        [Then(@"Verify for the Amazon Logo with Text (.*)")]
        public void ThenVerifyForTheAmazonLogo(string CompanyLogoName)
        {
            String CompanyLogoTextOnUI = SearchPage.VerifyCompanyLogo(CompanyLogoName);
            Assert.AreEqual(CompanyLogoTextOnUI, CompanyLogoName, "Company Logo Name Does not match as expected");
        }

        [Then(@"Verify the Items added with Product Name (.*)")]
        public void ThenVerifyTheItemsAddedWithProductName(string productName)
        {
            Boolean ItemCartValidationText = SearchPage.ItemInCartTextValidation(productName);
            Assert.IsTrue(ItemCartValidationText,"Item does not match in the Cart");
        }

        [When(@"Select Hamberger Menu Icon")]
        public void WhenSelectHambergerMenuIcon()
        {
            throw new PendingStepException();
        }

        [When(@"User selects options in categories (.*)")]
        public void WhenUserSelectsOptionInCategories(string options)
        {
            throw new PendingStepException();
        }


        [When(@"User selects (.*) options")]
        public void WhenUserSelectsOption(string options)
        {
            throw new PendingStepException();
        }

        [Then(@"Verify the Search Top Categories Logo with the Product Name (.*)")]
        public void ThenVerifyTheSearchTopCategoriesLogoWithTheProductName(string productName)
        {
            throw new PendingStepException();
        }
    }
}
