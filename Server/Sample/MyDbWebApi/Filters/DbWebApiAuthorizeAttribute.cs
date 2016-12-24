using System.Web;
using System.Web.Http;
using DataBooster.DbWebApi;
using MyDbWebApi.Controllers;
using Newtonsoft.Json.Linq;
using TokenAuthMVC.Managers;


//using TokenAuthMVC.Managers;

namespace MyDbWebApi
{
	public class DbWebApiAuthorizeAttribute : AuthorizeAttribute
	{
		private static IDbWebApiAuthorization _DbWebApiAuthorization;

		public static void RegisterWebApiAuthorization<T>() where T : IDbWebApiAuthorization, new()
		{
			_DbWebApiAuthorization = new T();
		}

		/// <param name="actionContext">The context.</param>
		/// <returns>true if the control is authorized; otherwise, false.</returns>
		protected override bool IsAuthorized(System.Web.Http.Controllers.HttpActionContext actionContext)
		{
			//var userIdentity = (actionContext.ControllerContext.Controller as DbWebApiController).User.Identity;

			//if (userIdentity == null || userIdentity.IsAuthenticated == false || string.IsNullOrEmpty(userIdentity.Name))
			//	return false;
            var content = actionContext.Request.Content.ReadAsStringAsync();
            if (content.Result == null)
                return false;
            dynamic data = JObject.Parse(content.Result);
            string token = data.token;
            //string user = userIdentity.Name;
			//string sp = actionContext.ControllerContext.RouteData.Values["sp"] as string;

			//return _DbWebApiAuthorization.IsAuthorized(user, sp);

            string ip = CommonManager.GetIP(((HttpContextWrapper)actionContext.Request.Properties["MS_HttpContext"]).Request);

            //string token = context.Request.Form["token"];          
            //string ip = CommonManager.GetIP(context.Request);
            string agent = ((HttpContextWrapper)actionContext.Request.Properties["MS_HttpContext"]).Request.UserAgent;

            return _DbWebApiAuthorization.IsAuthorized(token, ip, agent);
		}
	}
}