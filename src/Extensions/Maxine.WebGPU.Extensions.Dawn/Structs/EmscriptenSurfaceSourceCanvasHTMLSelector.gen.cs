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
    [NativeName("Name", "WGPUEmscriptenSurfaceSourceCanvasHTMLSelector")]
    public unsafe partial struct EmscriptenSurfaceSourceCanvasHTMLSelector
    {
        public EmscriptenSurfaceSourceCanvasHTMLSelector
        (
            ChainedStruct? chain = null,
            StringView? selector = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (selector is not null)
            {
                Selector = selector.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "selector")]
        public StringView Selector;
    }
}
