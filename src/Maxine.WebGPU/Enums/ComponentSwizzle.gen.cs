// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.WebGPU
{
    [NativeName("Name", "WGPUComponentSwizzle")]
    public enum ComponentSwizzle : int
    {
        [NativeName("Name", "WGPUComponentSwizzle_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUComponentSwizzle_Zero")]
        Zero = 0x1,
        [NativeName("Name", "WGPUComponentSwizzle_One")]
        One = 0x2,
        [NativeName("Name", "WGPUComponentSwizzle_R")]
        R = 0x3,
        [NativeName("Name", "WGPUComponentSwizzle_G")]
        G = 0x4,
        [NativeName("Name", "WGPUComponentSwizzle_B")]
        B = 0x5,
        [NativeName("Name", "WGPUComponentSwizzle_A")]
        A = 0x6,
        [NativeName("Name", "WGPUComponentSwizzle_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
