﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionFIleReading.NBT.Content
{
    internal class IntArrayTagContent : TagContent<int[]>
    {
        public override TagType TagType => TagType.IntArray;
    }
}
