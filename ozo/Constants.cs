﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ozo
{
    public class Constants
    {
        public static string Message
        {
            get { return "Message"; }
        }

        public static string ErrorOccurred
        {
            get { return "ErrorOccurred"; }
        }
        public const string SqlViewDokumenti = "SELECT * FROM vw_dokumenti";
    }
}
