﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagykönyv
{
    public class KonyvModel
    {
        public int Id { get; set; }
        public string Cim { get; set; }
        public int SzerzoId { get; set; }
        public int Helyezes { get; set; }

    }
}
