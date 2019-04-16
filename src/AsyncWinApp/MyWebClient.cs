using System;
using System.Net;

namespace AsyncLibs
{
    public class MyWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            if (address.AbsoluteUri.StartsWith("https:", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback += (s, cert, chain, sslPolicyErrors) => true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            }

            var request = (HttpWebRequest)base.GetWebRequest(address);
            request.Timeout = 6000; //设置超时为6s
            request.ReadWriteTimeout = 6000;
            return request;
        }
    }
}
