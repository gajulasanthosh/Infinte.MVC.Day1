﻿using System.Web;
using System.Web.Mvc;

namespace Infinte.MVC.Day1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
