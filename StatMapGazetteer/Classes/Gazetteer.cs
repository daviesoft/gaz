using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatMapGazetteer.Classes
{
    internal class Gazetteer
    {
        public List<string> addresses { get; set; }
        public List<int> ids { get; set; }
        public object guid { get; set; }
    }
}
