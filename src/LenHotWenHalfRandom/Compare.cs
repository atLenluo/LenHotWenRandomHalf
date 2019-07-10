﻿using System;
using System.Collections.Generic;

namespace LenHotWenHalfRandom
{
    public class StringCompare : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return -string.CompareOrdinal(x, y);
        }
    }
}
