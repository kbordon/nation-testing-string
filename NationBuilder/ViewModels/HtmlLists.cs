using System;
using System.Collections.Generic;

namespace System.Web.Mvc
{
    public static class HtmlLists
    {
        public static IEnumerable<Object> Governments = new List<object> {
            new {
                GovId = 1,
                Name = "Oligarchy"
            },
            new {
                ColorId = 2,
                Name = "Monarchy"
            }
        };
      
    }
}
