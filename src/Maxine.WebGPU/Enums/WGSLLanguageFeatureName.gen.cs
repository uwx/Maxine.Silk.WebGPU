// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Maxine.WebGPU
{
    [NativeName("Name", "WGPUWGSLLanguageFeatureName")]
    public enum WGSLLanguageFeatureName : int
    {
        [NativeName("Name", "WGPUWGSLLanguageFeatureName_ReadonlyAndReadwriteStorageTextures")]
        ReadonlyAndReadwriteStorageTextures = 0x1,
        [NativeName("Name", "WGPUWGSLLanguageFeatureName_Packed4x8IntegerDotProduct")]
        Packed4x8integerDotProduct = 0x2,
        [NativeName("Name", "WGPUWGSLLanguageFeatureName_UnrestrictedPointerParameters")]
        UnrestrictedPointerParameters = 0x3,
        [NativeName("Name", "WGPUWGSLLanguageFeatureName_PointerCompositeAccess")]
        PointerCompositeAccess = 0x4,
        [NativeName("Name", "WGPUWGSLLanguageFeatureName_UniformBufferStandardLayout")]
        UniformBufferStandardLayout = 0x5,
        [NativeName("Name", "WGPUWGSLLanguageFeatureName_SubgroupId")]
        SubgroupId = 0x6,
        [NativeName("Name", "WGPUWGSLLanguageFeatureName_TextureAndSamplerLet")]
        TextureAndSamplerLet = 0x7,
        [NativeName("Name", "WGPUWGSLLanguageFeatureName_SubgroupUniformity")]
        SubgroupUniformity = 0x8,
        [NativeName("Name", "WGPUWGSLLanguageFeatureName_TextureFormatsTier1")]
        TextureFormatsTier1 = 0x9,
        [NativeName("Name", "WGPUWGSLLanguageFeatureName_LinearIndexing")]
        LinearIndexing = 0xA,
        [NativeName("Name", "WGPUWGSLLanguageFeatureName_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
