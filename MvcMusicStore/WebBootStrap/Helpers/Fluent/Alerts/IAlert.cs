using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBootStrap.Helpers.Fluent.Alerts
{
    public interface IAlert : IAlertFluent
    {
        IAlertFluent Danger();

        IAlertFluent Info();

        IAlertFluent Success();

        IAlertFluent Warning();
    }
}
