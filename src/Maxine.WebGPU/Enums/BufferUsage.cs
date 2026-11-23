// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.WebGPU
{
    /// <summary>
    /// Bit flag set describing how a buffer may be used.
    /// </summary>
    /// <remarks>
    /// Hand-written: webgpu.h declares this as <c>typedef WGPUFlags WGPUBufferUsage;</c> — a 64-bit
    /// unsigned integer with the bit values as <c>static const</c> — rather than a C enum, so the
    /// generator emits a <c>ulong</c> field and the values as constants on
    /// <see cref="WebGPU" />. The type is 64-bit on purpose: every struct that carries one has to
    /// lay it out as eight bytes, which a default-width C# enum would not.
    /// </remarks>
    [Flags]
    [NativeName("Name", "WGPUBufferUsage")]
    public enum BufferUsage : ulong
    {
        [NativeName("Name", "WGPUBufferUsage_None")]
        None = 0x0,

        [NativeName("Name", "WGPUBufferUsage_MapRead")]
        MapRead = 0x1,

        [NativeName("Name", "WGPUBufferUsage_MapWrite")]
        MapWrite = 0x2,

        [NativeName("Name", "WGPUBufferUsage_CopySrc")]
        CopySrc = 0x4,

        [NativeName("Name", "WGPUBufferUsage_CopyDst")]
        CopyDst = 0x8,

        [NativeName("Name", "WGPUBufferUsage_Index")]
        Index = 0x10,

        [NativeName("Name", "WGPUBufferUsage_Vertex")]
        Vertex = 0x20,

        [NativeName("Name", "WGPUBufferUsage_Uniform")]
        Uniform = 0x40,

        [NativeName("Name", "WGPUBufferUsage_Storage")]
        Storage = 0x80,

        [NativeName("Name", "WGPUBufferUsage_Indirect")]
        Indirect = 0x100,

        [NativeName("Name", "WGPUBufferUsage_QueryResolve")]
        QueryResolve = 0x200,
    }
}
