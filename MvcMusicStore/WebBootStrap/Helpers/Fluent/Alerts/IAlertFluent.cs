using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WebBootStrap.Helpers.Fluent.Alerts
{
    public interface IAlertFluent : IHtmlString
    {
        IAlertFluent Dismissible(bool canDismiss = true);
    }
}
