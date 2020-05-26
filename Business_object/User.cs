using System;
using System.Collections.Generic;
using System.Text;

namespace TestSeleniumBasic.Business_object
{
    class User
    {
        public string SearchText { get; set; }
        public User (string SearchText)
        {
            this.SearchText = SearchText;
        }
    }
}
