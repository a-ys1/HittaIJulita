using System;
using System.Collections.Generic;
using System.Text;

namespace HittaJulita_koduppgift
{
    public class Adress
    {
        public string StreetName;
        public string Zip;
        public string City;

        public Adress(string streetName, string zip, string city)
        {
            StreetName = streetName;
            Zip = zip;
            City = city;

        }
    }
}
