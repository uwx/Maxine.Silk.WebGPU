// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Maxine.WebGPU.Extensions.Dawn
{
    /// <summary>
    /// <see cref="SType" /> values the Dawn header adds to the core enum.
    /// </summary>
    /// <remarks>
    /// Hand-written because the generator cannot produce them. Every header becomes its own project,
    /// so dawn-webgpu.h's copy of <c>WGPUSType</c> lives in this project rather than in Core, and
    /// ProjectWriter drops a non-core enum whose native name the core project already declares. The
    /// two tokens below therefore vanish from the generated tree even though the structs that carry
    /// them (<see cref="EmscriptenSurfaceSourceCanvasHTMLSelector" /> and
    /// <see cref="DawnCompilationMessageUtf16" />) are generated and compile.
    /// </remarks>
    public static class DawnSType
    {
        /// <summary>sType of a surface source naming a canvas element.</summary>
        public const SType EmscriptenSurfaceSourceCanvasHTMLSelector = (SType) 0x00040000;

        /// <summary>sType of a compilation message in UTF-16.</summary>
        public const SType CompilationMessageUtf16 = (SType) 0x0005003F;
    }

    /// <summary>
    /// <see cref="FeatureName" /> values the Dawn header adds to the core enum. Dropped for the same
    /// reason as <see cref="DawnSType" />.
    /// </summary>
    public static class DawnFeatureName
    {
        /// <summary>16-bit unorm texture formats.</summary>
        public const FeatureName Unorm16TextureFormats = (FeatureName) 0x0005000C;

        /// <summary>Indirect draws without a draw count buffer.</summary>
        public const FeatureName MultiDrawIndirect = (FeatureName) 0x00050031;
    }
}
