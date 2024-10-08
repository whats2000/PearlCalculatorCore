﻿using PearlCalculatorLib.PearlCalculationLib.MathLib;
using PearlCalculatorLib.PearlCalculationLib;
using PearlCalculatorLib.PearlCalculationLib.World;
using PearlCalculatorLib.PearlCalculationLib.AABB;

namespace RTPearlCalculatorLib.Blocks
{
    public class SlabBlock : Block
    {
        public static readonly Space3D BlockSize = new Space3D(1, 0.5, 1);

        public override Space3D Size => BlockSize;

        public SlabBlock(Space3D pos) : base(pos)
        {

        }
    }
}
