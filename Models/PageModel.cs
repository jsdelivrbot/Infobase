﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactDotNetDemo.Models
{
    public class PageModel
    {
        public string LanguageCode { get; set; }
        public PageModel(string languageCode)
        {
            this.LanguageCode = languageCode;
        }
    }
}
