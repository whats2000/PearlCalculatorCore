﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionFIleReading.NBT.Content
{
    internal class DoubleTagContent : TagContent<double>
    {
        internal override TagType TagType => TagType.Double;
    }
}
