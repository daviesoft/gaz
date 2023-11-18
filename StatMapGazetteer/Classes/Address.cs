using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatMapGazetteer.Classes
{
    internal class Address
    {
        public string address { get; set; }
        public string record { get; set; }
        public Point point { get; set; }
    }

    public class Point
    {
        public string easting { get; set; }
        public string northing { get; set; }
    }
}
