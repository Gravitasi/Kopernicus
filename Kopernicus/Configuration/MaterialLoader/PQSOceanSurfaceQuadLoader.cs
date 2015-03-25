// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

using Kopernicus.MaterialWrapper;

namespace Kopernicus
{
    namespace Configuration
    {
        public class PQSOceanSurfaceQuadLoader : PQSOceanSurfaceQuad
        {
            // Main Color, default = (1,1,1,1)
            [ParserTarget("color", optional = true)]
            private ColorParser colorSetter
            {
                set { base.color = value.value; }
            }

            // Color From Space, default = (1,1,1,1)
            [ParserTarget("colorFromSpace", optional = true)]
            private ColorParser colorFromSpaceSetter
            {
                set { base.colorFromSpace = value.value; }
            }

            // Specular Color, default = (1,1,1,1)
            [ParserTarget("specColor", optional = true)]
            private ColorParser specColorSetter
            {
                set { base.specColor = value.value; }
            }

            // Shininess, default = 0.078125
            [ParserTarget("shininess", optional = true)]
            private NumericParser<float> shininessSetter
            {
                set { base.shininess = value.value; }
            }

            // Gloss, default = 0.078125
            [ParserTarget("gloss", optional = true)]
            private NumericParser<float> glossSetter
            {
                set { base.gloss = value.value; }
            }

            // Tex Tiling, default = 1
            [ParserTarget("tiling", optional = true)]
            private NumericParser<float> tilingSetter
            {
                set { base.tiling = value.value; }
            }

            // Tex0, default = "white" {}
            [ParserTarget("waterTex", optional = true)]
            private Texture2DParser waterTexSetter
            {
                set { base.waterTex = value.value; }
            }

            [ParserTarget("waterTexScale", optional = true)]
            private Vector2Parser waterTexScaleSetter
            {
                set { base.waterTexScale = value.value; }
            }

            [ParserTarget("waterTexOffset", optional = true)]
            private Vector2Parser waterTexOffsetSetter
            {
                set { base.waterTexOffset = value.value; }
            }

            // Tex1, default = "white" {}
            [ParserTarget("waterTex1", optional = true)]
            private Texture2DParser waterTex1Setter
            {
                set { base.waterTex1 = value.value; }
            }

            [ParserTarget("waterTex1Scale", optional = true)]
            private Vector2Parser waterTex1ScaleSetter
            {
                set { base.waterTex1Scale = value.value; }
            }

            [ParserTarget("waterTex1Offset", optional = true)]
            private Vector2Parser waterTex1OffsetSetter
            {
                set { base.waterTex1Offset = value.value; }
            }

            // Normal Tiling, default = 1
            [ParserTarget("bTiling", optional = true)]
            private NumericParser<float> bTilingSetter
            {
                set { base.bTiling = value.value; }
            }

            // Normalmap0, default = "bump" {}
            [ParserTarget("bumpMap", optional = true)]
            private Texture2DParser bumpMapSetter
            {
                set { base.bumpMap = value.value; }
            }

            [ParserTarget("bumpMapScale", optional = true)]
            private Vector2Parser bumpMapScaleSetter
            {
                set { base.bumpMapScale = value.value; }
            }

            [ParserTarget("bumpMapOffset", optional = true)]
            private Vector2Parser bumpMapOffsetSetter
            {
                set { base.bumpMapOffset = value.value; }
            }

            // Water Movement, default = 1
            [ParserTarget("displacement", optional = true)]
            private NumericParser<float> displacementSetter
            {
                set { base.displacement = value.value; }
            }

            // Water Freq, default = 1
            [ParserTarget("dispFreq", optional = true)]
            private NumericParser<float> dispFreqSetter
            {
                set { base.dispFreq = value.value; }
            }

            // Mix, default = 1
            [ParserTarget("mix", optional = true)]
            private NumericParser<float> mixSetter
            {
                set { base.mix = value.value; }
            }

            // Opacity, default = 1
            [ParserTarget("oceanOpacity", optional = true)]
            private NumericParser<float> oceanOpacitySetter
            {
                set { base.oceanOpacity = value.value; }
            }

            // Falloff Power, default = 1
            [ParserTarget("falloffPower", optional = true)]
            private NumericParser<float> falloffPowerSetter
            {
                set { base.falloffPower = value.value; }
            }

            // Falloff Exp, default = 2
            [ParserTarget("falloffExp", optional = true)]
            private NumericParser<float> falloffExpSetter
            {
                set { base.falloffExp = value.value; }
            }

            // AP Fog Color, default = (0,0,1,1)
            [ParserTarget("fogColor", optional = true)]
            private ColorParser fogColorSetter
            {
                set { base.fogColor = value.value; }
            }

            // AP Height Fall Off, default = 1
            [ParserTarget("heightFallOff", optional = true)]
            private NumericParser<float> heightFallOffSetter
            {
                set { base.heightFallOff = value.value; }
            }

            // AP Global Density, default = 1
            [ParserTarget("globalDensity", optional = true)]
            private NumericParser<float> globalDensitySetter
            {
                set { base.globalDensity = value.value; }
            }

            // AP Atmosphere Depth, default = 1
            [ParserTarget("atmosphereDepth", optional = true)]
            private NumericParser<float> atmosphereDepthSetter
            {
                set { base.atmosphereDepth = value.value; }
            }

            // FogColorRamp, default = "white" {}
            [ParserTarget("fogColorRamp", optional = true)]
            private Texture2DParser fogColorRampSetter
            {
                set { base.fogColorRamp = value.value; }
            }

            [ParserTarget("fogColorRampScale", optional = true)]
            private Vector2Parser fogColorRampScaleSetter
            {
                set { base.fogColorRampScale = value.value; }
            }

            [ParserTarget("fogColorRampOffset", optional = true)]
            private Vector2Parser fogColorRampOffsetSetter
            {
                set { base.fogColorRampOffset = value.value; }
            }

            // FadeStart, default = 1
            [ParserTarget("fadeStart", optional = true)]
            private NumericParser<float> fadeStartSetter
            {
                set { base.fadeStart = value.value; }
            }

            // FadeEnd, default = 1
            [ParserTarget("fadeEnd", optional = true)]
            private NumericParser<float> fadeEndSetter
            {
                set { base.fadeEnd = value.value; }
            }

            // PlanetOpacity, default = 1
            [ParserTarget("planetOpacity", optional = true)]
            private NumericParser<float> planetOpacitySetter
            {
                set { base.planetOpacity = value.value; }
            }

            // Constructors
            public PQSOceanSurfaceQuadLoader () : base() { }
            public PQSOceanSurfaceQuadLoader (string contents) : base (contents) { }
            public PQSOceanSurfaceQuadLoader (Material material) : base(material) { }
        }
    }
}
