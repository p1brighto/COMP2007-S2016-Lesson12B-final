﻿using System.Web;
using System.Web.Mvc;

namespace COMP2007_S2016_Lesson12B_final
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
