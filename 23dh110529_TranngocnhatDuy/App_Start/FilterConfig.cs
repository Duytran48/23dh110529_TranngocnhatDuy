﻿using System.Web;
using System.Web.Mvc;

namespace _23dh110529_TranngocnhatDuy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
