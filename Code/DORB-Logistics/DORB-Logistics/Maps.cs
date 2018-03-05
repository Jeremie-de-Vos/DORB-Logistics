using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DORB_Logistics
{
    class Maps
    {
        //API-Keys
        static string API_Key = "AIzaSyDxStXk9HEF_XshadQ-vWITobvNHRm9cZI";

        //Button-Event
        private void GO_btn_Click(object sender, EventArgs e)
        {

        }

        //Get all adress components based on street-name & house-number
        public static List<Address> PostalcodeResults(string streetname, string number)
        {
            //Request url
            string url = @"https://maps.googleapis.com/maps/api/geocode/json?address=" + streetname + " " + number + "&result_type=street_address&key=" + API_Key;

            //Webrequest-streamreader
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            StreamReader reader = new StreamReader(data);

            // json-formatted string from maps api
            string responseFromServer = reader.ReadToEnd();

            //Create lists for the results from the request
            JObject googleSearch = JObject.Parse(responseFromServer);
            IList<JToken> results = googleSearch["results"].Children().ToList();

            //list to return
            List<Address> list = new List<Address>();

            //foreach result
            foreach (JToken Result in results)
            {
                //Some local variable
                string street = "";
                string house_number = "";
                string zipcode = "";
                string country = "";
                string place = "";
                string provincie = "";
                string Township = "";

                //Foreach adress component from result
                foreach (JToken Adress_Components in Result.First().First())
                {
                    //List with types
                    IList<JToken> types = Adress_Components["types"].Children().ToList();

                    //Foreach type
                    foreach (JToken type in types)
                    {
                        //determ witch Variable it is
                        if (type.ToString() == "route")
                            street = Adress_Components["long_name"].ToString();
                        else if (type.ToString() == "street_number")
                            house_number = Adress_Components["long_name"].ToString();
                        else if (type.ToString() == "postal_code")
                            zipcode = Adress_Components["long_name"].ToString();
                        else if (type.ToString() == "country")
                            country = Adress_Components["long_name"].ToString();
                        else if (type.ToString() == "locality")
                            place = Adress_Components["long_name"].ToString();
                        else if (type.ToString() == "administrative_area_level_1")
                            provincie = Adress_Components["long_name"].ToString();
                        else if (type.ToString() == "administrative_area_level_2")
                            Township = Adress_Components["long_name"].ToString();

                    }
                }
                //MessageBox.Show(" Street: " + street + "\n House nr: " + house_number + "\n Zipcode: " + zipcode + "\n Country: " + country + "\n Place: " + place + "\n Province: " + provincie + "\n Township: " + Township);
                list.Add(new Address(street, house_number, zipcode, country, place, provincie, Township));
            }
            //return the lists
            return list;
        }

        //Get directions from one point to another
        private void getdirections()
        {
            string API_Key = "AIzaSyCma7_8t_C5plc0N822u7WHqwZCkU6MWqM";
            string url = @"https://maps.googleapis.com/maps/api/directions/json?origin=75+9th+Ave+New+York,+NY&destination=MetLife+Stadium+1+MetLife+Stadium+Dr+East+Rutherford,+NJ+07073&key=" + API_Key;

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            StreamReader reader = new StreamReader(data);

            // json-formatted string from maps api
            string responseFromServer = reader.ReadToEnd();
            //richTextBox1.Text = responseFromServer;
        }
    }
}
internal class Address
{
    internal string street;
    internal string house_number;
    internal string zipcode;
    internal string country;
    internal string place;
    internal string provincie;
    internal string township;

    internal Address(string Street, string House_number, string Zipcode, string Country, string Place, string Provincie, string TownShip)
    {
        street = Street;
        house_number = House_number;
        zipcode = Zipcode;
        country = Country;
        place = Place;
        provincie = Provincie;
        township = TownShip;
    }
}