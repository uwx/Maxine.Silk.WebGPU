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

namespace Maxine.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUDawnCompilationMessageUtf16")]
    public unsafe partial struct DawnCompilationMessageUtf16
    {
        public DawnCompilationMessageUtf16
        (
            ChainedStruct? chain = null,
            ulong? linePos = null,
            ulong? offset = null,
            ulong? length = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (linePos is not null)
            {
                LinePos = linePos.Value;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (length is not null)
            {
                Length = length.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "linePos")]
        public ulong LinePos;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "offset")]
        public ulong Offset;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "length")]
        public ulong Length;
    }
}
