using System.Net;

namespace StarshipRegistryGUI
    {

    public enum httpVerb
        {
        GET,
        POST,
        PUT,
        DELETE
        }

    class StapiClient
        {

        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public StapiClient()
            {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
            }

        public string makeRequest()
            {
            string strResponse = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                /*     if (response.StatusCode != HttpStatusCode.OK)
                         {
                         throw new ApplicationException("Something went wrong.");
                         }*/


                using (Stream responseStream = response.GetResponseStream())
                    {
                    if (responseStream != null)
                        {
                        using (StreamReader reader = new StreamReader(responseStream))
                            {
                            strResponse = reader.ReadToEnd();
                            }
                        }
                    }
                }

            return strResponse;
            }

        }
    }
