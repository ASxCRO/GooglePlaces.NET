using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace DataAccessLayer
{
    public class PlaceRepository
    {
        private static List<Supan_Places> _googlePlaces;
        public static string GenerateUrl(int type, decimal lat, decimal lng, int radius)
        {
            String sType = String.Empty;
            using (var mapDB = new MapEntities())
            {

                sType = mapDB.Supan_PlaceTypes.Where(t => t.TYPE_ID == type).Select(t => t.TYPE_VALUE).FirstOrDefault().ToString();
 
            }
            string Lat = Convert.ToString(lat).Replace(',', '.');
            string Lng = Convert.ToString(lng).Replace(',', '.');
            var url =
                "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location="
                + Lat
                + ","
                + Lng
                + "&radius=" + radius
                + "&type=" + sType
                + "&key=AIzaSyBSuPs2jtLhJs-9BHt-4iIZhABawlJvHhs";

            return url;
        }

        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }

        public static List<Supan_Places> GetPlaces(int type, decimal lat, decimal lng, int radius)
        {
            _googlePlaces = new List<Supan_Places>();

            string json = CallRestMethod(GenerateUrl(type, lat, lng, radius));
            JObject jsonObject = JObject.Parse(json);
            JToken results = jsonObject.SelectToken("results");

            foreach (JObject place in results)
            {
                _googlePlaces.Add(
                    new Supan_Places
                    {
                        PLACE_NAME = (string)place.GetValue("name"),
                        PLACE_LAT = (decimal)place.SelectToken("geometry.location.lat"),
                        PLACE_LNG = (decimal)place.SelectToken("geometry.location.lng"),
                        PLACE_TYPE = type,
                        PLACE_ADDRESS = "\n" + (string)place.GetValue("vicinity") + ", \n" + Convert.ToString(place.SelectToken("plus_code.compound_code")).Split(' ').Last()
                    });
            }
            return _googlePlaces;
        }
    }
}
