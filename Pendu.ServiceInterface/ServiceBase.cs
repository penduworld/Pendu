using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using ServiceStack;
using ServiceStack.Auth;
using ServiceStack.Text;

namespace Pendu.ServiceInterface
{
    public class ServiceBase : Service
    {
        private ILog _log;
        protected ILog Log => _log ?? (_log = LogManager.GetLogger(GetType()));

        protected ServiceBase()
        {
            log4net.Config.XmlConfigurator.Configure();
            JsConfig.IncludeNullValues = true;
            JsConfig.EmitCamelCaseNames = true;

            /* formats in and out dates in ISO8601 */
            JsConfig<DateTime>.SerializeFn = time => new DateTime(time.Ticks, DateTimeKind.Local).ToString("o");
            JsConfig<DateTime?>.SerializeFn = time => time != null ? new DateTime(time.Value.Ticks, DateTimeKind.Local).ToString("o") : null;
            JsConfig.DateHandler = DateHandler.ISO8601;
        }

        // will use this for security perposes 
        //protected bool HasPermission(PermissionFlag permission, Lob lob)
        //{
        //    IAuthSession session = this.GetSession();

        //    try
        //    {
        //        string perm = $"{lob.ToString()}::{permission.ToString()}";
        //        return session.Permission.Contains(perm);
        //    }
        //    catch
        //    {

        //    }
        //    return false;
        //}

    }



}
