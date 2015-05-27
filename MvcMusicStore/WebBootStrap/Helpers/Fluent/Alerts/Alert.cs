using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace WebBootStrap.Helpers.Fluent.Alerts
{
    public class Alert : IAlert
    {
        private AlertStyle style;
        private bool dissmissible;
        private string message;

        public Alert(string message)
        {
            this.message = message;
        }

        public IAlertFluent Danger()
        {
            return this.StyleMethod(AlertStyle.Danger);
        }

        public IAlertFluent Info()
        {
            return this.StyleMethod(AlertStyle.Info);
        }

        public IAlertFluent Success()
        {
            return this.StyleMethod(AlertStyle.Success);
        }

        public IAlertFluent Warning()
        {
            return this.StyleMethod(AlertStyle.Warning);
        }

        private IAlertFluent StyleMethod(AlertStyle style)
        {
            this.style = style;
            return new AlertFluent(this);
        }

        public IAlertFluent Dismissible(bool canDismiss = true)
        {
            this.dissmissible = canDismiss;
            return new AlertFluent(this);
        }

        public string ToHtmlString()
        {
            var alertDiv = new TagBuilder("div");
            alertDiv.AddCssClass("alert");
            alertDiv.AddCssClass(string.Format("alert-{0}", this.style.ToString().ToLower()));
            alertDiv.InnerHtml = this.message;
            if (this.dissmissible)
            {
                alertDiv.AddCssClass("alert-dismissible");
                alertDiv.InnerHtml += this.AddCloseButton();
            }
            return alertDiv.ToString();
        }

        private TagBuilder AddCloseButton()
        {
            var closeButton = new TagBuilder("button");
            closeButton.AddCssClass("close");
            closeButton.Attributes.Add("data-dismiss", "alert");
            closeButton.InnerHtml = "&times;";
            return closeButton;
        }

        
    }
}
