// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:True,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True;n:type:ShaderForge.SFN_Final,id:4795,x:32953,y:32712,varname:node_4795,prsc:2|emission-9799-OUT,alpha-405-OUT;n:type:ShaderForge.SFN_Multiply,id:923,x:30948,y:31063,varname:node_923,prsc:2|A-3996-OUT,B-9767-RGB;n:type:ShaderForge.SFN_Tex2d,id:7101,x:29664,y:32326,ptovrint:False,ptlb:Sprite,ptin:_Sprite,varname:node_1341,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:8a3ffcc3e855e994ca4a298ca0df6097,ntxv:0,isnm:False;n:type:ShaderForge.SFN_VertexColor,id:9767,x:29591,y:33236,varname:node_9767,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:4360,x:30410,y:31103,ptovrint:False,ptlb:Density Contrast,ptin:_DensityContrast,varname:node_5897,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Power,id:3996,x:30694,y:31063,varname:node_3996,prsc:2|VAL-7101-R,EXP-4360-OUT;n:type:ShaderForge.SFN_Color,id:3681,x:30803,y:32245,ptovrint:False,ptlb:Temperature Colour,ptin:_TemperatureColour,varname:node_364,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.3931034,c3:0,c4:1;n:type:ShaderForge.SFN_Multiply,id:2451,x:31017,y:32130,varname:node_2451,prsc:2|A-9780-OUT,B-3681-RGB;n:type:ShaderForge.SFN_Add,id:9799,x:31686,y:31832,varname:node_9799,prsc:2|A-1769-OUT,B-9976-OUT;n:type:ShaderForge.SFN_Slider,id:8425,x:30431,y:32139,ptovrint:False,ptlb:Temperature Contrast,ptin:_TemperatureContrast,varname:node_8425,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:5;n:type:ShaderForge.SFN_Power,id:9780,x:30790,y:32034,varname:node_9780,prsc:2|VAL-5535-OUT,EXP-8425-OUT;n:type:ShaderForge.SFN_Multiply,id:1769,x:31296,y:31156,cmnt:Density,varname:node_1769,prsc:2|A-923-OUT,B-533-RGB;n:type:ShaderForge.SFN_Subtract,id:7478,x:30834,y:33498,varname:node_7478,prsc:2|A-5985-OUT,B-3748-OUT;n:type:ShaderForge.SFN_OneMinus,id:4831,x:30248,y:33613,varname:node_4831,prsc:2|IN-9767-A;n:type:ShaderForge.SFN_Color,id:533,x:30881,y:31272,ptovrint:False,ptlb:Normalizer,ptin:_Normalizer,varname:node_533,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.3161765,c2:0.3161765,c3:0.3161765,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:8461,x:30184,y:33488,ptovrint:False,ptlb:Opacity Erosion Attenuation,ptin:_OpacityErosionAttenuation,varname:node_8461,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:5205,x:30369,y:33454,varname:node_5205,prsc:2|A-7101-R,B-8461-OUT;n:type:ShaderForge.SFN_Multiply,id:5535,x:30546,y:31917,varname:node_5535,prsc:2|A-7101-G,B-7589-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7589,x:30295,y:32016,ptovrint:False,ptlb:Temperature Control,ptin:_TemperatureControl,varname:node_7589,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:9976,x:31214,y:32130,cmnt:Temperature,varname:node_9976,prsc:2|A-2451-OUT,B-7101-G;n:type:ShaderForge.SFN_Multiply,id:3748,x:30533,y:33598,varname:node_3748,prsc:2|A-5205-OUT,B-4831-OUT;n:type:ShaderForge.SFN_Lerp,id:5985,x:30551,y:33039,varname:node_5985,prsc:2|A-7101-B,B-7101-A,T-6246-OUT;n:type:ShaderForge.SFN_Slider,id:6246,x:30128,y:33213,ptovrint:False,ptlb:Edge Blur,ptin:_EdgeBlur,varname:node_6246,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1,max:1;n:type:ShaderForge.SFN_Depth,id:7279,x:30731,y:34151,varname:node_7279,prsc:2;n:type:ShaderForge.SFN_SceneDepth,id:9292,x:30731,y:34004,varname:node_9292,prsc:2;n:type:ShaderForge.SFN_Subtract,id:1996,x:30911,y:34037,varname:node_1996,prsc:2|A-9292-OUT,B-7279-OUT;n:type:ShaderForge.SFN_Multiply,id:5209,x:31058,y:34151,varname:node_5209,prsc:2|A-1996-OUT,B-4971-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4971,x:30879,y:34272,ptovrint:False,ptlb:Soft Particle Param,ptin:_SoftParticleParam,varname:node_4971,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Clamp01,id:4332,x:31249,y:34151,cmnt:Soft Particles,varname:node_4332,prsc:2|IN-5209-OUT;n:type:ShaderForge.SFN_Clamp01,id:2773,x:31028,y:33501,varname:node_2773,prsc:2|IN-7478-OUT;n:type:ShaderForge.SFN_Multiply,id:405,x:31747,y:33804,varname:node_405,prsc:2|A-2773-OUT,B-4332-OUT;proporder:7101-4360-7589-3681-8425-533-8461-6246-4971;pass:END;sub:END;*/

Shader "Shader Forge/NewShader" {
    Properties {
        _Sprite ("Sprite", 2D) = "white" {}
        _DensityContrast ("Density Contrast", Float ) = 1
        _TemperatureControl ("Temperature Control", Float ) = 1
        _TemperatureColour ("Temperature Colour", Color) = (1,0.3931034,0,1)
        _TemperatureContrast ("Temperature Contrast", Range(0, 5)) = 1
        _Normalizer ("Normalizer", Color) = (0.3161765,0.3161765,0.3161765,1)
        _OpacityErosionAttenuation ("Opacity Erosion Attenuation", Float ) = 1
        _EdgeBlur ("Edge Blur", Range(0, 1)) = 0.1
        _SoftParticleParam ("Soft Particle Param", Float ) = 0.1
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _CameraDepthTexture;
            uniform sampler2D _Sprite; uniform float4 _Sprite_ST;
            uniform float _DensityContrast;
            uniform float4 _TemperatureColour;
            uniform float _TemperatureContrast;
            uniform float4 _Normalizer;
            uniform float _OpacityErosionAttenuation;
            uniform float _TemperatureControl;
            uniform float _EdgeBlur;
            uniform float _SoftParticleParam;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float4 vertexColor : COLOR;
                float4 projPos : TEXCOORD2;
                UNITY_FOG_COORDS(3)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.posWorld = mul(_Object2World, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
////// Lighting:
////// Emissive:
                float4 _Sprite_var = tex2D(_Sprite,TRANSFORM_TEX(i.uv0, _Sprite));
                float3 emissive = (((pow(_Sprite_var.r,_DensityContrast)*i.vertexColor.rgb)*_Normalizer.rgb)+((pow((_Sprite_var.g*_TemperatureControl),_TemperatureContrast)*_TemperatureColour.rgb)*_Sprite_var.g));
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,(saturate((lerp(_Sprite_var.b,_Sprite_var.a,_EdgeBlur)-((_Sprite_var.r*_OpacityErosionAttenuation)*(1.0 - i.vertexColor.a))))*saturate(((sceneZ-partZ)*_SoftParticleParam))));
                UNITY_APPLY_FOG_COLOR(i.fogCoord, finalRGBA, fixed4(0.5,0.5,0.5,1));
                return finalRGBA;
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
