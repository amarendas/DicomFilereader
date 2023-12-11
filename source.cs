using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DicomFileReader
{
    internal class source
    {
        public int sourceno { get; set; }
        public string sourceType{ get; set; }
        public string isotope { get; set; }
        public string unit { get; set; }
        public double sStrength { get; set; }
        DateTime calibDate, calibTime;
        public DateTime CalibDate
        {
            set { this.calibDate = Convert.ToDateTime(value); }
            get { return calibDate; }
        }
        public DateTime CalibTime
        {
            set { this.calibTime = Convert.ToDateTime(value); }
            get { return calibTime; }
        } 
        
        public source()
        {
            sourceno = 0;
            sourceType = "Nil";
            isotope = "Nil";
            unit = "Nil";
            sStrength = 0;
            calibDate = DateTime.Now;
            calibTime = DateTime.Now;

        }

        


    }
}
