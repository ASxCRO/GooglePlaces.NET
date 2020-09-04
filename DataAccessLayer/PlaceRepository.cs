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
                + "&key=******************************************; /* Insert YOUR api key! */

            return url;
        }

        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/json";
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
            string address = string.Empty;
            string street = string.Empty;
            string city = string.Empty;
            string country = string.Empty;

            _googlePlaces = new List<Supan_Places>();
            string json = CallRestMethod(GenerateUrl(type, lat, lng, radius));
            JObject jsonObject = JObject.Parse(json);
            JToken results = jsonObject.SelectToken("results");

            foreach (JObject place in results)
            {
                address = (string)place.GetValue("vicinity");
                string[] addressParts = address.Split(',');
                if (addressParts.Count() > 1)
                {
                    street = addressParts[addressParts.Count() - 2].TrimStart();
                }
                else
                {
                    street = "Ulica nepoznata";
                }
                city = addressParts[addressParts.Count()-1].TrimStart();
                country = Convert.ToString(place.SelectToken("plus_code.compound_code")).Split(',').Last().TrimStart();
                _googlePlaces.Add(
                    new Supan_Places
                    {
                        PLACE_NAME = (string)place.GetValue("name"),
                        PLACE_LAT = (decimal)place.SelectToken("geometry.location.lat"),
                        PLACE_LNG = (decimal)place.SelectToken("geometry.location.lng"),
                        PLACE_TYPE = type,
                        PLACE_ADDRESS = "\n" + street + ",\n" +city + ", \n" + country
                    });
            }
            return _googlePlaces;
        }
    }
}
