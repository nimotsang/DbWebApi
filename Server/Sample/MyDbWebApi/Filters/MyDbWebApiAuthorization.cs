using System;
using System.Linq;
using System.Text;
using DataBooster.DbWebApi;
using TokenAuthMVC.Managers;

namespace MyDbWebApi
{
	public class MyDbWebApiAuthorization : IDbWebApiAuthorization
	{
        public bool IsAuthorized(string token, string ip, object state = null)
        {
            return SecurityManager.IsTokenValid(token, ip, state as string);
        }
    }
}
