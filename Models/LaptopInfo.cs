using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDotNet.Models
{
    public class LaptopInfo
    {
        public String MALAPTOP { get; set; }
        public String TENLAPTOP { get; set; }
        public String HANG { get; set; }
        public int GIABAN { get; set; }
        public String SERIES { get; set; }
        public String MAU { get; set; }
        public String CPU { get; set; }
        public String VGA { get; set; }
        public String RAM { get; set; }
        public String KICHTHUOCMANHINH { get; set; }
        public String OCUNG { get; set; }
        public String BANPHIM { get; set; }
        public String PIN { get; set; }
        public String KHOILUONG { get; set; }
        public String LINKHINH1 { get; set; }
        public String LINKHINH2 { get; set; }
        public String LINKHINH3 { get; set; }
        public String LINKHINH4 { get; set; }
        public String LINKHINH5 { get; set; }

        public LaptopInfo()
        {

        }
        public LaptopInfo(string mALAPTOP, string tENLAPTOP, string hANG, int gIABAN, string sERIES, string Mau, string cPU, string vGA, string rAM, string kICHTHUOCMANHINH, string oCUNG, string bANPHIM, string pIN, string kHOILUONG, string lINKHINH1, string lINKHINH2, string lINKHINH3, string lINKHINH4, string lINKHINH5)
        {
            MALAPTOP = mALAPTOP;
            TENLAPTOP = tENLAPTOP;
            HANG = hANG;
            GIABAN = gIABAN;
            SERIES = sERIES;
            MAU = MAU;
            CPU = cPU;
            VGA = vGA;
            RAM = rAM;
            KICHTHUOCMANHINH = kICHTHUOCMANHINH;
            OCUNG = oCUNG;
            BANPHIM = bANPHIM;
            PIN = pIN;
            KHOILUONG = kHOILUONG;
            LINKHINH1 = lINKHINH1;
            LINKHINH2 = lINKHINH2;
            LINKHINH3 = lINKHINH3;
            LINKHINH4 = lINKHINH4;
            LINKHINH5 = lINKHINH5;
        }
    }
}