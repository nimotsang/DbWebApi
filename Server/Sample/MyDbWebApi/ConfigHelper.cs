using System.Configuration;

namespace MyDbWebApi
{
	public static class ConfigHelper
	{
		private const string _UserNameReservedParameterSettingKey = "UserNameReservedParameter";
        private const string _POSServiceUrlSettingKey = "POSServiceUrl";
        private const string _AppIdSettingKey = "AppId";
        private const string _CorsOriginsSettingKey = "CorsOrigins";
		private const string _SupportsCredentialsSettingKey = "CorsSupportsCredentials";
		private const string _PreflightMaxAgeSettingKey = "CorsPreflightMaxAge";
        private static string _UserNameParameterSettingKey = "UserNameParameter";
        private static string _PasswordParameterSettingKey = "PasswordParameter";
        private static string _TableNameParameterSettingKey = "TableNameParameter";
        private static string _UserNameReservedParameter = null;
		public static string UserNameReservedParameter
		{
			get
			{
				if (_UserNameReservedParameter == null)
				{
					_UserNameReservedParameter = ConfigurationManager.AppSettings[_UserNameReservedParameterSettingKey];

					if (_UserNameReservedParameter == null)
						_UserNameReservedParameter = string.Empty;
				}

				return _UserNameReservedParameter;
			}
			set
			{
				_UserNameReservedParameter = value;
			}
		}
        private static string _TableNameParameter = null;
        public static string TableNameParameter
        {
            get
            {
                if (_TableNameParameter == null)
                {
                    _TableNameParameter = ConfigurationManager.AppSettings[_TableNameParameterSettingKey];

                    if (_TableNameParameter == null)
                        _TableNameParameter = string.Empty;
                }

                return _TableNameParameter;
            }
            set
            {
                _TableNameParameter = value;
            }
        }
        private static string _UserNameParameter = null;
        public static string UserNameParameter
        {
            get
            {
                if (_UserNameParameter == null)
                {
                    _UserNameParameter = ConfigurationManager.AppSettings[_UserNameParameterSettingKey];

                    if (_UserNameParameter == null)
                        _UserNameParameter = string.Empty;
                }

                return _UserNameParameter;
            }
            set
            {
                _UserNameParameter = value;
            }
        }
        private static string _PasswordParameter = null;
        public static string PasswordParameter
        {
            get
            {
                if (_PasswordParameter == null)
                {
                    _PasswordParameter = ConfigurationManager.AppSettings[_PasswordParameterSettingKey];

                    if (_PasswordParameter == null)
                        _PasswordParameter = string.Empty;
                }

                return _PasswordParameter;
            }
            set
            {
                _PasswordParameter = value;
            }
        }
        private static string _posServiceUrl = null;
        public static string POSServiceUrl
        {
            get
            {
                if (_posServiceUrl == null)
                {
                    _posServiceUrl = ConfigurationManager.AppSettings[_POSServiceUrlSettingKey];

                    if (_posServiceUrl == null)
                        _posServiceUrl = string.Empty;
                }

                return _posServiceUrl;
            }
            set
            {
                _posServiceUrl = value;
            }
        }

        private static string _appId = null;
        public static string AppId
        {
            get
            {
                if (_appId == null)
                {
                    _appId = ConfigurationManager.AppSettings[_AppIdSettingKey];

                    if (_appId == null)
                        _appId = string.Empty;
                }

                return _appId;
            }
            set
            {
                _appId = value;
            }
        }
        private static string _CorsOrigins = null;
		public static string CorsOrigins
		{
			get
			{
				if (_CorsOrigins == null)
				{
					_CorsOrigins = ConfigurationManager.AppSettings[_CorsOriginsSettingKey];

					if (_CorsOrigins == null)
						_CorsOrigins = string.Empty;
				}

				return _CorsOrigins;
			}
			set
			{
				_CorsOrigins = value;
			}
		}

		private static bool? _SupportsCredentials = null;
		public static bool SupportsCredentials
		{
			get
			{
				if (_SupportsCredentials == null)
				{
					string withCredentials = ConfigurationManager.AppSettings[_SupportsCredentialsSettingKey];
					bool bCredentials = false;

					if (!string.IsNullOrEmpty(withCredentials))
						bool.TryParse(withCredentials, out bCredentials);

					_SupportsCredentials = bCredentials;
				}

				return _SupportsCredentials.Value;
			}
			set
			{
				_SupportsCredentials = value;
			}
		}

		private static long? _PreflightMaxAge = null;
		public static long PreflightMaxAge
		{
			get
			{
				if (_PreflightMaxAge == null)
				{
					string strPreflightMaxAge = ConfigurationManager.AppSettings[_PreflightMaxAgeSettingKey];
					long preflightMaxAge = 0L;

					if (!string.IsNullOrEmpty(strPreflightMaxAge))
						long.TryParse(strPreflightMaxAge, out preflightMaxAge);

					_PreflightMaxAge = preflightMaxAge;
				}

				return _PreflightMaxAge.Value;
			}
			set
			{
				_PreflightMaxAge = value;
			}
		}
	}
}