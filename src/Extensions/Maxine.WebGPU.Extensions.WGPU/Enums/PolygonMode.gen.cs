// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUPolygonMode")]
    public enum PolygonMode : int
    {
        [NativeName("Name", "WGPUPolygonMode_Fill")]
        Fill = 0x0,
        [NativeName("Name", "WGPUPolygonMode_Line")]
        Line = 0x1,
        [NativeName("Name", "WGPUPolygonMode_Point")]
        Point = 0x2,
    }
}
