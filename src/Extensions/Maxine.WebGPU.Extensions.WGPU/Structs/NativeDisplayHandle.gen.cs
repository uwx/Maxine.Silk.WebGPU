// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Maxine.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUNativeDisplayHandle")]
    public unsafe partial struct NativeDisplayHandle
    {
        public NativeDisplayHandle
        (
            NativeDisplayHandleType? type = null,
            NativeDisplayHandleData? data = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (data is not null)
            {
                Data = data.Value;
            }
        }


        [NativeName("Type", "WGPUNativeDisplayHandleType")]
        [NativeName("Type.Name", "WGPUNativeDisplayHandleType")]
        [NativeName("Name", "type")]
        public NativeDisplayHandleType Type;

        [NativeName("Type", "union (unnamed union at wgpu.h:1116:5)")]
        [NativeName("Type.Name", "union (unnamed union at wgpu.h:1116:5)")]
        [NativeName("Name", "data")]
        public NativeDisplayHandleData Data;
    }
}
