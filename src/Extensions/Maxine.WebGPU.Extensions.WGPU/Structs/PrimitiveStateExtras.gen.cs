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
    [NativeName("Name", "WGPUPrimitiveStateExtras")]
    public unsafe partial struct PrimitiveStateExtras
    {
        public PrimitiveStateExtras
        (
            ChainedStruct? chain = null,
            PolygonMode? polygonMode = null,
            Silk.NET.Core.Bool32? conservative = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (polygonMode is not null)
            {
                PolygonMode = polygonMode.Value;
            }

            if (conservative is not null)
            {
                Conservative = conservative.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUPolygonMode")]
        [NativeName("Type.Name", "WGPUPolygonMode")]
        [NativeName("Name", "polygonMode")]
        public PolygonMode PolygonMode;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "conservative")]
        public Silk.NET.Core.Bool32 Conservative;
    }
}
