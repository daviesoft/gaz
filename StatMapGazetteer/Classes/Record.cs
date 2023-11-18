using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatMapGazetteer.Classes
{
    internal class Record
    {
        public string UPRN { get; set; }
        public string USRN { get; set; }
        public string SAO_START_NUMBER { get; set; }
        public string SAO_START_SUFFIX { get; set; }
        public string SAO_END_NUMBER { get; set; }
        public string SAO_END_SUFFIX { get; set; }
        public string SAO_TEXT { get; set; }
        public string PAO_START_NUMBER { get; set; }
        public string PAO_START_SUFFIX { get; set; }
        public string PAO_END_NUMBER { get; set; }
        public string PAO_END_SUFFIX { get; set; }
        public string PAO_TEXT { get; set; }
        public string STREET_DESCRIPTOR { get; set; }
        public string POSTCODE { get; set; }
        public string POST_TOWN { get; set; }
        public string LANGUAGE { get; set; }
        public string ADMINISTRATIVE_AREA { get; set; }
        public string LOCALITY_NAME { get; set; }
        public string TOWN_NAME { get; set; }
        public string EASTING { get; set; }
        public string NORTHING { get; set; }
        public string ADDRESS_LOCATION { get; set; }
        public string POSTAL_ADDRESS { get; set; }
        public string CROSS_REFERENCE { get; set; }
        public string LOGICAL_STATUS { get; set; }
        public string LOGICAL_STATUS_DESCRIPTION { get; set; }
        public string BLPU_CLASS_1ST { get; set; }
        public string BLPU_CLASS_2ND { get; set; }
        public string BLPU_CLASS_FULL { get; set; }
        public string ORGANISATION { get; set; }
        public string GEO_SINGLE_ADDRESS_LABEL { get; set; }
        public string MI_PRINX { get; set; }
    }
}

