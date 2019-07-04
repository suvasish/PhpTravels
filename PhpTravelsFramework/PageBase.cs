using OpenQA.Selenium;
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
    }
}
