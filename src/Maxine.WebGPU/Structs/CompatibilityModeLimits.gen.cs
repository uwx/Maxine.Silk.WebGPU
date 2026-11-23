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

namespace Maxine.WebGPU
{
    [NativeName("Name", "WGPUCompatibilityModeLimits")]
    public unsafe partial struct CompatibilityModeLimits
    {
        public CompatibilityModeLimits
        (
            ChainedStruct? chain = null,
            uint? maxStorageBuffersInVertexStage = null,
            uint? maxStorageTexturesInVertexStage = null,
            uint? maxStorageBuffersInFragmentStage = null,
            uint? maxStorageTexturesInFragmentStage = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (maxStorageBuffersInVertexStage is not null)
            {
                MaxStorageBuffersInVertexStage = maxStorageBuffersInVertexStage.Value;
            }

            if (maxStorageTexturesInVertexStage is not null)
            {
                MaxStorageTexturesInVertexStage = maxStorageTexturesInVertexStage.Value;
            }

            if (maxStorageBuffersInFragmentStage is not null)
            {
                MaxStorageBuffersInFragmentStage = maxStorageBuffersInFragmentStage.Value;
            }

            if (maxStorageTexturesInFragmentStage is not null)
            {
                MaxStorageTexturesInFragmentStage = maxStorageTexturesInFragmentStage.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxStorageBuffersInVertexStage")]
        public uint MaxStorageBuffersInVertexStage;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxStorageTexturesInVertexStage")]
        public uint MaxStorageTexturesInVertexStage;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxStorageBuffersInFragmentStage")]
        public uint MaxStorageBuffersInFragmentStage;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxStorageTexturesInFragmentStage")]
        public uint MaxStorageTexturesInFragmentStage;
    }
}
