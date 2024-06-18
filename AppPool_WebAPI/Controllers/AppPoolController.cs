using Microsoft.AspNetCore;
using System.Collections.Generic;
using System.Web.Http;
using Microsoft.Web.Administration;
using Microsoft.AspNetCore.Mvc;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;

namespace AppPool_WebAPI.Controllers
{
   
    [RoutePrefix("api/AppPool")]
    public class AppPoolController : ControllerBase
    {
        [HttpGet, Microsoft.AspNetCore.Mvc.Route("GetNames")]
        public IEnumerable<AppPool> GetAppPools()
        {
            var appPools = new List<AppPool>();
            using (ServerManager manager = new ServerManager())
            {
                foreach (var pool in manager.ApplicationPools)
                {
                    appPools.Add(new AppPool
                    {
                        Name = pool.Name,
                        Status = pool.State.ToString()
                    });
                }
            }
            return appPools;
        }

        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("Recycle/{name}")]
        public IHttpActionResult Recycle(string name)
        {
            using (ServerManager manager = new ServerManager())
            {
                var appPool = manager.ApplicationPools[name];
                if (appPool == null) return (IHttpActionResult)NotFound();
                appPool.Recycle();
            }
            return (IHttpActionResult)Ok();
        }

        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("Start/{name}")]
        public IHttpActionResult Start(string name)
        {
            using (ServerManager manager = new ServerManager())
            {
                var appPool = manager.ApplicationPools[name];
                if (appPool == null) return (IHttpActionResult)NotFound();
                appPool.Start();
            }
            return (IHttpActionResult)Ok();
        }

        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("Stop/{name}")]
        public IHttpActionResult Stop(string name)
        {
            using (ServerManager manager = new ServerManager())
            {
                var appPool = manager.ApplicationPools[name];
                if (appPool == null) return (IHttpActionResult)NotFound();
                appPool.Stop();
            }
            return (IHttpActionResult)Ok();
        }
    }

}
