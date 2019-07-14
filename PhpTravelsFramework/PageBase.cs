using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhpTravelsFramework
{
    public class PageBase
    {
        protected readonly IWebElement pageBody;

        public PageBase()
        {
            pageBody = Driver.Instance.FindElement(By.TagName("body"));
        }

        protected bool Check_if_it_exists(string _xpath)
        {
            try
            {
                Driver.Instance.FindElement(By.XPath(_xpath));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }

    }
 }
