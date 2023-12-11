using EvilDICOM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicomFileReader
{
    internal class readDicomFile
    {
        public readDicomFile(string fileloc)
        {
            var dcm = DICOMObject.Read(fileloc);
        }
    }
}
