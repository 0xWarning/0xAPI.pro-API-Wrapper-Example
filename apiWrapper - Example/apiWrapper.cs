using System;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;

namespace apiWrapper___Example
{
    public static class Extension
    {
        public static string ToEnumMemberAttrValue(this Enum @enum)
        {
            var attr =
                @enum.GetType().GetMember(@enum.ToString()).FirstOrDefault()?.
                    GetCustomAttributes(false).OfType<EnumMemberAttribute>().
                    FirstOrDefault();
            if (attr == null)
                return @enum.ToString();
            return attr.Value;
        }
    }

    internal class apiWrapper
    {
        public static WebClient apiWrapClient = new WebClient();

        /// <summary>
        /// Provides a collection of APIs that can be used with this wrapper.
        /// </summary>
        public enum APIS : int
        {
            [EnumMember(Value = "geoip")]
            GeoIP,
            [EnumMember(Value = "host2ip")]
            Host2IP,
            [EnumMember(Value = "ip2host")]
            IP2Host,
            [EnumMember(Value = "isup")]
            IsUP,
            [EnumMember(Value = "detectcf")]
            DetectCloudflare,
            [EnumMember(Value = "getheaders")]
            GetHeaders,
            [EnumMember(Value = "validip")]
            ValidIP,
            [EnumMember(Value = "webshot")]
            Webshot,
            [EnumMember(Value = "detectcf")]
            DetectCF,
            [EnumMember(Value = "keygen")]
            KeyGen,
            [EnumMember(Value = "passgen")]
            PasswordGen,
            [EnumMember(Value = "cdemail")]
            DisposableEmail,
            [EnumMember(Value = "checkemail")]
            ValidEmail,
            [EnumMember(Value = "waf")]
            WebAppFirewall,
            [EnumMember(Value = "steaminfo")]
            SteamInfo,
            [EnumMember(Value = "nscheck")]
            NameserverCheck,
            [EnumMember(Value = "porstscan")]
            PortScan,

        }

        /// <summary>
        /// Contains the hard-coded URL for the API endpoints.
        /// </summary>
        public class apiInfo
        {
            public static string Url = "https://api.0xapi.pro/";
        }

        /// <summary>
        /// Represents the global key used for API authentication.
        /// </summary>
        public class apiAuthentication
        {
            public static string Key { get; set; }
        }

        /// <summary>
        /// Verifies the provided API key for authentication purposes.
        /// </summary>
        /// <param name="key">The API user key to be checked.</param>
        public bool checkKey(string key) // To Be Done. Need key check api 
        {
            string checkResult = apiWrapClient.DownloadString("" + key);


            if (checkResult == "valid")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Executes the specified API call with optional parameters and returns the result.
        /// </summary>
        /// <param name="api">The API to call.</param>
        /// <param name="parameters">Optional parameters to supply. Can be a single parameter or multiple parameters.</param>
        /// <returns>The result of the API call.</returns>
        public string doApiCall(APIS api, params string[] parameters)
        {
            if (api == APIS.GeoIP)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.GeoIP) + "?key=" + apiAuthentication.Key + "&ip=" + parameters[0] + "&output=html");
                return apiCallResult;

            }
            else if (api == APIS.Host2IP)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.Host2IP) + "?key=" + apiAuthentication.Key + "&host=" + parameters[0] + "&output=html");
                return apiCallResult;
            }
            else if (api == APIS.IP2Host)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.IP2Host) + "?key=" + apiAuthentication.Key + "&ip=" + parameters[0] + "&output=html");
                return apiCallResult;
            }
            else if (api == APIS.IsUP)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.IsUP) + "?key=" + apiAuthentication.Key + "&host=" + parameters[0] + "&output=html");
                return apiCallResult;
            }
            else if (api == APIS.DetectCF)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.DetectCF) + "?key=" + apiAuthentication.Key + "&host=" + parameters[0] + "&output=html");
                return apiCallResult;
            }
            else if (api == APIS.GetHeaders)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.GetHeaders) + "?key=" + apiAuthentication.Key + "&host=" + parameters[0] + "&output=html");
                return apiCallResult;
            }
            else if (api == APIS.ValidIP)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.ValidIP) + "?key=" + apiAuthentication.Key + "&ip=" + parameters[0] + "&output=html");
                return apiCallResult;
            }
            else if (api == APIS.Webshot)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.Webshot) + "?key=" + apiAuthentication.Key + "&url=" + parameters[0] + "&output=html");
                return apiCallResult;
            }
            else if (api == APIS.KeyGen)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.KeyGen) + "?key=" + apiAuthentication.Key + "&template=!!!-$$$-???&amount=5");
                return apiCallResult;
            }
            else if (api == APIS.PasswordGen)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.PasswordGen) + "?key=" + apiAuthentication.Key + "&length=8&include=numbers,letters,chars");
                return apiCallResult;
            }
            else if (api == APIS.PortScan)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.PortScan) + "?key=" + apiAuthentication.Key + "&port=" + parameters[0]);
                return apiCallResult;
            }
            else if (api == APIS.DisposableEmail)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.DisposableEmail) + "?key=" + apiAuthentication.Key + "&email=" + parameters[0]);
                return apiCallResult;
            }
            else if (api == APIS.ValidEmail)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.ValidEmail) + "?key=" + apiAuthentication.Key + "&email=" + parameters[0]);
                return apiCallResult;
            }
            else if (api == APIS.WebAppFirewall)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.WebAppFirewall) + "?key=" + apiAuthentication.Key + "&url=" + parameters[0]);
                return apiCallResult;
            }
            else if (api == APIS.SteamInfo)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.SteamInfo) + "?key=" + apiAuthentication.Key + "&profile=" + parameters[0]);
                return apiCallResult;
            }
            else if (api == APIS.NameserverCheck)
            {
                string apiCallResult = apiWrapClient.DownloadString(apiInfo.Url + Extension.ToEnumMemberAttrValue(APIS.NameserverCheck) + "?key=" + apiAuthentication.Key + "&url=" + parameters[0]);
                return apiCallResult;
            }
            else
            {
                return "Something is wrong"; // Check provided api string
            }
        }
    }
}
