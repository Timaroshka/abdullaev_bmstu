﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

using Lab5;

namespace Lab5
{
    public class ParallelSearchResult
    {
        public string word { get; set; }

        public int dist { get; set; }

        public int ThreadNum { get; set; }
    }
}