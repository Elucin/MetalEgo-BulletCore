// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:4013,x:32877,y:32454,varname:node_4013,prsc:2|diff-1446-OUT,spec-7690-OUT,gloss-842-A,normal-7664-RGB,emission-4127-RGB;n:type:ShaderForge.SFN_Multiply,id:4991,x:31147,y:31286,varname:node_4991,prsc:2|A-2956-OUT,B-8963-RGB;n:type:ShaderForge.SFN_Multiply,id:8977,x:31007,y:31550,varname:node_8977,prsc:2|A-2457-OUT,B-8521-RGB;n:type:ShaderForge.SFN_OneMinus,id:2956,x:30964,y:31177,varname:node_2956,prsc:2|IN-2457-OUT;n:type:ShaderForge.SFN_Fresnel,id:2457,x:30768,y:31337,varname:node_2457,prsc:2|EXP-3432-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3432,x:30583,y:31359,ptovrint:False,ptlb:Colour Falloff,ptin:_ColourFalloff,varname:node_3432,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Add,id:4610,x:31377,y:31448,cmnt:Paint Colour,varname:node_4610,prsc:2|A-4991-OUT,B-8977-OUT;n:type:ShaderForge.SFN_Color,id:8963,x:30975,y:31353,ptovrint:False,ptlb:Front Colour,ptin:_FrontColour,varname:node_8963,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Color,id:8521,x:30823,y:31576,ptovrint:False,ptlb:Back Colour,ptin:_BackColour,varname:_FrontColour_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0.006896734,c3:1,c4:1;n:type:ShaderForge.SFN_LightVector,id:8221,x:29718,y:32369,varname:node_8221,prsc:2;n:type:ShaderForge.SFN_ViewReflectionVector,id:3868,x:29718,y:32526,varname:node_3868,prsc:2;n:type:ShaderForge.SFN_Dot,id:3496,x:29896,y:32441,varname:node_3496,prsc:2,dt:1|A-8221-OUT,B-3868-OUT;n:type:ShaderForge.SFN_Power,id:8321,x:30093,y:32441,varname:node_8321,prsc:2|VAL-3496-OUT,EXP-6922-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6922,x:29896,y:32641,ptovrint:False,ptlb:Flake Gloss,ptin:_FlakeGloss,varname:node_6922,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Multiply,id:4990,x:30311,y:32441,varname:node_4990,prsc:2|A-8321-OUT,B-9490-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9490,x:30093,y:32675,ptovrint:False,ptlb:Flake Intensity,ptin:_FlakeIntensity,varname:_FakeGloss_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_LightColor,id:7496,x:30311,y:32290,varname:node_7496,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2944,x:30505,y:32395,cmnt:Gloss,varname:node_2944,prsc:2|A-7496-RGB,B-4990-OUT;n:type:ShaderForge.SFN_Tex2d,id:6597,x:30181,y:32834,ptovrint:False,ptlb:Flakes,ptin:_Flakes,varname:node_6597,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Add,id:6987,x:30411,y:32905,varname:node_6987,prsc:2|A-6597-RGB,B-2613-OUT;n:type:ShaderForge.SFN_ValueProperty,id:2613,x:30181,y:33051,ptovrint:False,ptlb:Flake Contrast,ptin:_FlakeContrast,varname:node_2613,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Color,id:520,x:30395,y:32705,ptovrint:False,ptlb:Flakes Colour,ptin:_FlakesColour,varname:node_520,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8308824,c2:0.6360548,c3:0,c4:1;n:type:ShaderForge.SFN_Multiply,id:7750,x:30593,y:32801,cmnt:Flakes,varname:node_7750,prsc:2|A-520-RGB,B-6987-OUT;n:type:ShaderForge.SFN_Multiply,id:4440,x:30892,y:32473,varname:node_4440,prsc:2|A-2944-OUT,B-7750-OUT;n:type:ShaderForge.SFN_Add,id:4467,x:31719,y:31642,varname:node_4467,prsc:2|A-4610-OUT,B-4440-OUT;n:type:ShaderForge.SFN_Tex2d,id:9454,x:31360,y:32442,ptovrint:False,ptlb:Paint Mask,ptin:_PaintMask,varname:node_9454,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:1446,x:32472,y:32315,varname:node_1446,prsc:2|A-2778-OUT,B-7058-RGB;n:type:ShaderForge.SFN_Tex2d,id:7058,x:31654,y:32967,ptovrint:False,ptlb:AO Map,ptin:_AOMap,varname:node_7058,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-9101-UVOUT;n:type:ShaderForge.SFN_Fresnel,id:1435,x:31368,y:33251,varname:node_1435,prsc:2|EXP-3432-OUT;n:type:ShaderForge.SFN_OneMinus,id:6439,x:31597,y:33287,varname:node_6439,prsc:2|IN-1435-OUT;n:type:ShaderForge.SFN_Multiply,id:4427,x:31944,y:33063,varname:node_4427,prsc:2|A-7058-RGB,B-1435-OUT;n:type:ShaderForge.SFN_Tex2d,id:7664,x:32402,y:32686,ptovrint:False,ptlb:Normal Map,ptin:_NormalMap,varname:_AOMap_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_TexCoord,id:9101,x:31364,y:32977,varname:node_9101,prsc:2,uv:1;n:type:ShaderForge.SFN_Multiply,id:6825,x:32388,y:33100,varname:node_6825,prsc:2|A-4427-OUT,B-6439-OUT;n:type:ShaderForge.SFN_Multiply,id:7727,x:31522,y:31882,varname:node_7727,prsc:2|A-5728-RGB,B-1721-RGB;n:type:ShaderForge.SFN_Color,id:1721,x:31203,y:32006,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5019608,c2:0.5019608,c3:0.5019608,c4:1;n:type:ShaderForge.SFN_Tex2d,id:5728,x:31187,y:31783,ptovrint:True,ptlb:Diffuse,ptin:_MainTex,varname:_MainTex,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_OneMinus,id:4298,x:31685,y:32106,varname:node_4298,prsc:2|IN-9454-RGB;n:type:ShaderForge.SFN_Lerp,id:2778,x:31978,y:32025,varname:node_2778,prsc:2|A-4467-OUT,B-7727-OUT,T-4298-OUT;n:type:ShaderForge.SFN_Tex2d,id:842,x:31366,y:33665,ptovrint:False,ptlb:Specular,ptin:_Specular,varname:node_842,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Lerp,id:7690,x:32507,y:33193,varname:node_7690,prsc:2|A-6825-OUT,B-842-RGB,T-4298-OUT;n:type:ShaderForge.SFN_Tex2d,id:4127,x:32578,y:32862,ptovrint:False,ptlb:Emission,ptin:_Emission,varname:node_4127,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False;proporder:9454-8963-8521-3432-6597-520-2613-6922-9490-7058-7664-5728-1721-842-4127;pass:END;sub:END;*/

Shader "Shader Forge/Alien Pain" {
    Properties {
        _PaintMask ("Paint Mask", 2D) = "white" {}
        _FrontColour ("Front Colour", Color) = (1,0,0,1)
        _BackColour ("Back Colour", Color) = (0,0.006896734,1,1)
        _ColourFalloff ("Colour Falloff", Float ) = 1
        _Flakes ("Flakes", 2D) = "white" {}
        _FlakesColour ("Flakes Colour", Color) = (0.8308824,0.6360548,0,1)
        _FlakeContrast ("Flake Contrast", Float ) = 1
        _FlakeGloss ("Flake Gloss", Float ) = 2
        _FlakeIntensity ("Flake Intensity", Float ) = 1
        _AOMap ("AO Map", 2D) = "white" {}
        _NormalMap ("Normal Map", 2D) = "bump" {}
        _MainTex ("Diffuse", 2D) = "white" {}
        _Color ("Color", Color) = (0.5019608,0.5019608,0.5019608,1)
        _Specular ("Specular", 2D) = "white" {}
        _Emission ("Emission", 2D) = "black" {}
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float _ColourFalloff;
            uniform float4 _FrontColour;
            uniform float4 _BackColour;
            uniform float _FlakeGloss;
            uniform float _FlakeIntensity;
            uniform sampler2D _Flakes; uniform float4 _Flakes_ST;
            uniform float _FlakeContrast;
            uniform float4 _FlakesColour;
            uniform sampler2D _PaintMask; uniform float4 _PaintMask_ST;
            uniform sampler2D _AOMap; uniform float4 _AOMap_ST;
            uniform sampler2D _NormalMap; uniform float4 _NormalMap_ST;
            uniform float4 _Color;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform sampler2D _Specular; uniform float4 _Specular_ST;
            uniform sampler2D _Emission; uniform float4 _Emission_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
                float3 normalDir : TEXCOORD3;
                float3 tangentDir : TEXCOORD4;
                float3 bitangentDir : TEXCOORD5;
                LIGHTING_COORDS(6,7)
                UNITY_FOG_COORDS(8)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _NormalMap_var = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(i.uv0, _NormalMap)));
                float3 normalLocal = _NormalMap_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float4 _Specular_var = tex2D(_Specular,TRANSFORM_TEX(i.uv0, _Specular));
                float gloss = _Specular_var.a;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float4 _AOMap_var = tex2D(_AOMap,TRANSFORM_TEX(i.uv1, _AOMap));
                float node_1435 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_ColourFalloff);
                float4 _PaintMask_var = tex2D(_PaintMask,TRANSFORM_TEX(i.uv0, _PaintMask));
                float3 node_4298 = (1.0 - _PaintMask_var.rgb);
                float3 specularColor = lerp(((_AOMap_var.rgb*node_1435)*(1.0 - node_1435)),_Specular_var.rgb,node_4298);
                float3 directSpecular = (floor(attenuation) * _LightColor0.xyz) * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float node_2457 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_ColourFalloff);
                float4 _Flakes_var = tex2D(_Flakes,TRANSFORM_TEX(i.uv0, _Flakes));
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float3 diffuseColor = (lerp(((((1.0 - node_2457)*_FrontColour.rgb)+(node_2457*_BackColour.rgb))+((_LightColor0.rgb*(pow(max(0,dot(lightDirection,viewReflectDirection)),_FlakeGloss)*_FlakeIntensity))*(_FlakesColour.rgb*(_Flakes_var.rgb+_FlakeContrast)))),(_MainTex_var.rgb*_Color.rgb),node_4298)*_AOMap_var.rgb);
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 _Emission_var = tex2D(_Emission,TRANSFORM_TEX(i.uv0, _Emission));
                float3 emissive = _Emission_var.rgb;
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float _ColourFalloff;
            uniform float4 _FrontColour;
            uniform float4 _BackColour;
            uniform float _FlakeGloss;
            uniform float _FlakeIntensity;
            uniform sampler2D _Flakes; uniform float4 _Flakes_ST;
            uniform float _FlakeContrast;
            uniform float4 _FlakesColour;
            uniform sampler2D _PaintMask; uniform float4 _PaintMask_ST;
            uniform sampler2D _AOMap; uniform float4 _AOMap_ST;
            uniform sampler2D _NormalMap; uniform float4 _NormalMap_ST;
            uniform float4 _Color;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform sampler2D _Specular; uniform float4 _Specular_ST;
            uniform sampler2D _Emission; uniform float4 _Emission_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float4 posWorld : TEXCOORD2;
                float3 normalDir : TEXCOORD3;
                float3 tangentDir : TEXCOORD4;
                float3 bitangentDir : TEXCOORD5;
                LIGHTING_COORDS(6,7)
                UNITY_FOG_COORDS(8)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _NormalMap_var = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(i.uv0, _NormalMap)));
                float3 normalLocal = _NormalMap_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float4 _Specular_var = tex2D(_Specular,TRANSFORM_TEX(i.uv0, _Specular));
                float gloss = _Specular_var.a;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float4 _AOMap_var = tex2D(_AOMap,TRANSFORM_TEX(i.uv1, _AOMap));
                float node_1435 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_ColourFalloff);
                float4 _PaintMask_var = tex2D(_PaintMask,TRANSFORM_TEX(i.uv0, _PaintMask));
                float3 node_4298 = (1.0 - _PaintMask_var.rgb);
                float3 specularColor = lerp(((_AOMap_var.rgb*node_1435)*(1.0 - node_1435)),_Specular_var.rgb,node_4298);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float node_2457 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_ColourFalloff);
                float4 _Flakes_var = tex2D(_Flakes,TRANSFORM_TEX(i.uv0, _Flakes));
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float3 diffuseColor = (lerp(((((1.0 - node_2457)*_FrontColour.rgb)+(node_2457*_BackColour.rgb))+((_LightColor0.rgb*(pow(max(0,dot(lightDirection,viewReflectDirection)),_FlakeGloss)*_FlakeIntensity))*(_FlakesColour.rgb*(_Flakes_var.rgb+_FlakeContrast)))),(_MainTex_var.rgb*_Color.rgb),node_4298)*_AOMap_var.rgb);
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
