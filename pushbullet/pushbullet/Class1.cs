using System;
using System.Text;
using System.Collections.Generic;
using Crestron.SimplSharp;      // For Basic SIMPL# Classes
using Crestron.SimplSharp.Net;
using Crestron.SimplSharp.Net.Https;
using Crestron.SimplSharp.CrestronIO;

namespace Go4Gold
{

    
    public class pushbullet
    {

        private string URL =  "https://api.pushbullet.com/v2/users/me";
        public string Token;

        pushbullet()
        {
            
                    
        }




        private class MyHttpsClient : HttpsClient
        {
            public MyHttpsClient()
            {
                this.PeerVerification = false;
                this.HostVerification = false;
                this.Verbose = true;
            }
        }

        private class MyHttpsClientRequest : HttpsClientRequest
        {
            public MyHttpsClientRequest(string _URL, string _token)
            {
                string _uri = _URL;
                this.KeepAlive = true;
                this.Url.Parse(_uri);
                this.Header.AddHeader(new HttpsHeader("Access-Token", _token));
                this.Header.AddHeader(new HttpsHeader("response_type", "token"));
                this.Header.AddHeader(new HttpsHeader("Content-Type", "application/json"));
                this.Header.AddHeader(new HttpsHeader("Expect", ""));
            }
        }

        
    }
}