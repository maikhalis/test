using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBootStrap.Helpers.Fluent.Alerts
{
    public static class AlertHelper
    {
        public static IAlert Alert(this HtmlHelper helper, string message)
        {
            return new Alert(message);
        }
    }
}