using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBootStrap.Helpers.Fluent.Alerts
{
    public class AlertFluent : IAlertFluent
    {
        private readonly IAlert parent;

        public AlertFluent(IAlert parent)
        {
            this.parent = parent; 
        }

        public IAlertFluent Dismissible(bool canDismiss = true)
        {
            return this.parent.Dismissible(canDismiss);
        }

        public string ToHtmlString()
        {
            return this.parent.ToHtmlString();
        }
    }
}