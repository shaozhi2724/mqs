using System;
using System.Text;
using System.Net;
using System.IO;

namespace DQS.App
{
    class HttpUtil
    {
        /*
         * get请求
         */
        public static string Get(string Url)
        {
            //System.GC.Collect();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Proxy = null;
            request.KeepAlive = false;
            request.Method = "GET";
            request.ContentType = "application/json; charset=UTF-8";
            request.AutomaticDecompression = DecompressionMethods.GZip;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
            string retString = myStreamReader.ReadToEnd();

            myStreamReader.Close();
            myResponseStream.Close();

            if (response != null)
            {
                response.Close();
            }
            if (request != null)
            {
                request.Abort();
            }

            return retString;
        }

        /*
        * post请求 Referer(允许为空)
        */
        public static string Post(string Url, string Data)
        {
            string retString = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.Method = "POST";
                byte[] bytes = Encoding.UTF8.GetBytes(Data);
                //request.ContentType = "application/json";
                request.ContentLength = bytes.Length;
                request.ContentType = "text/plain";
                request.UserAgent = "PostmanRuntime/10.24.2";
                request.Accept = "application/json";
                request.Headers.Add("Accept-Encoding", "gzip, deflate, br");
                Stream myResponseStream = request.GetRequestStream();
                myResponseStream.Write(bytes, 0, bytes.Length);

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader myStreamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                retString = myStreamReader.ReadToEnd();

                myStreamReader.Close();
                myResponseStream.Close();

                if (response != null)
                {
                    response.Close();
                }
                if (request != null)
                {
                    request.Abort();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("异常：" + ex);
            }

            return retString;
        }
    }
}
