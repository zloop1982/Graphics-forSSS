﻿using UnityEditor.ShaderGraph.Internal;

namespace UnityEditor.Rendering.Universal.ShaderGraph
{
    static class UniversalSubShaders
    {
        const string kPipelineTag = "UniversalPipeline";

        public static SubShaderDescriptor PBR = new SubShaderDescriptor()
        {
            pipelineTag = kPipelineTag,
            passes = new PassCollection
            {
                { UniversalPasses.Forward },
                { UniversalPasses.ShadowCaster },
                { UniversalPasses.DepthOnly },
                { UniversalPasses.Meta },
                { UniversalPasses._2D },
            },
        };

        public static SubShaderDescriptor Unlit = new SubShaderDescriptor()
        {
            pipelineTag = kPipelineTag,
            passes = new PassCollection
            {
                { UniversalPasses.Unlit },
                { UniversalPasses.ShadowCaster },
                { UniversalPasses.DepthOnly },
            },
        };

        public static SubShaderDescriptor SpriteLit = new SubShaderDescriptor()
        {
            pipelineTag = kPipelineTag,
            renderTypeOverride = "Transparent",
            renderQueueOverride = "Transparent",
            passes = new PassCollection
            {
                { UniversalPasses.SpriteLit },
                { UniversalPasses.SpriteNormal },
                { UniversalPasses.SpriteForward },
            },
        };

        public static SubShaderDescriptor SpriteUnlit = new SubShaderDescriptor()
        {
            pipelineTag = kPipelineTag,
            renderTypeOverride = "Transparent",
            renderQueueOverride = "Transparent",
            passes = new PassCollection
            {
                { UniversalPasses.SpriteUnlit },
            },
        };
    }
}
