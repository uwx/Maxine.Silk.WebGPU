// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.WebGPU
{
    /// <summary>
    /// How a buffer is mapped for CPU access.
    /// </summary>
    /// <remarks>Hand-written for the reason on <see cref="BufferUsage" />.</remarks>
    [Flags]
    [NativeName("Name", "WGPUMapMode")]
    public enum MapMode : ulong
    {
        [NativeName("Name", "WGPUMapMode_None")]
        None = 0x0,

        [NativeName("Name", "WGPUMapMode_Read")]
        Read = 0x1,

        [NativeName("Name", "WGPUMapMode_Write")]
        Write = 0x2,
    }
}
