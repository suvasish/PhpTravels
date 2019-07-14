using OpenQA.Selenium;
using System;

namespace PhpTravelsFramework
{
    public class SearchPageClass : PageBase
    {
        private static IWebElement searchPage;

        public SearchPageClass(IWebElement _pageElem)
        {
            searchPage = _pageElem;
        }

        public void Select_search_option(string criteria)
        {
            var xPath = $".//ul[contains(@class, 'nav-tabs')]/li//span[contains(text(),'{criteria}')]";
            searchPage.FindElement(By.XPath(xPath)).Click();

            xPath = $".//li[contains(@role, 'presentation') and contains(@class, 'active') and contains(@data-title, '{criteria.ToLower()}')]";

            if ( ! Check_if_it_exists(xPath))
                throw new Exception("Not in flight search page!");
           
        }

    }
}