﻿using System.Web;
using System.Web.Mvc;

namespace IntershipCode_bank_login
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
