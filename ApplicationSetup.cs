using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvilDICOM.Core;

namespace DicomFileReader

{
    struct Channel
    {
        public int NumberofControlPoints; // Optional
        public int chNumber;
        public double chLength;
        public double chTotalTime;
        public string soueceMovementType;
        public double sourceApplicatorLength;
        public double FinalCumulativeTimeWeight;
        public double stepSize;

        public List<CpData> cplist ;

    };
    struct CpData
    {
        public int ptIndex;
        public double relPosition;
        public double cumulativeTimeWeight;
    }
    class ApplicationSetup
    {
        public string ApplicationSetupType { get; set; } 
        public int ApplicationSetupNumber { get; set; }
        public double TotalReferenceAirKerma { get; set; }
        public List<Channel> channelList;

        public ApplicationSetup()
        {
            ApplicationSetupType = "Nill";
            ApplicationSetupNumber = 0;
            TotalReferenceAirKerma = 0;
            channelList = new List<Channel>();
        }

        public void Process(List<EvilDICOM.Core.Element.Sequence> s)
        {

        }

    }
}
