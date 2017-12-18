using System;
using System.Linq;
using System.Text;
using DataBooster.DbWebApi;
using TokenAuthMVC.Managers;

namespace MyDbWebApi
{
	public class MyDbWebApiAuthorization : IDbWebApiAuthorization
	{
        public bool IsAuthorized(string token, string userAgent, object state = null)
        {
            return SecurityManager.IsTokenValid(token, userAgent);
        }
    }
}
