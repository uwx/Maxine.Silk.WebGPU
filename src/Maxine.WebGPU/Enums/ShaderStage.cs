// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.WebGPU
{
    /// <summary>
    /// Which shader stages may see a bind group entry.
    /// </summary>
    /// <remarks>Hand-written for the reason on <see cref="BufferUsage" />.</remarks>
    [Flags]
    [NativeName("Name", "WGPUShaderStage")]
    public enum ShaderStage : ulong
    {
        [NativeName("Name", "WGPUShaderStage_None")]
        None = 0x0,

        [NativeName("Name", "WGPUShaderStage_Vertex")]
        Vertex = 0x1,

        [NativeName("Name", "WGPUShaderStage_Fragment")]
        Fragment = 0x2,

        [NativeName("Name", "WGPUShaderStage_Compute")]
        Compute = 0x4,
    }
}
