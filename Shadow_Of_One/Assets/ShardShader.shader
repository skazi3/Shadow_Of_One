// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/ShardShader" {
	//Vars
	Properties{
		_MainTexture("Main Color RBG Hello!", Color) = "white" {}
		_Color("Green", Color) = (1,1,1,1)
	}

	SubShader{
		Pass{
			CGPROGRAM

			#pragma vertex vertexFunction
			#pragma fragment fragmentFunction

			#include "UnityCG.cginc"


			struct appdata {
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;

			};

			struct v2f {
				float4 position : SV_POSITION;
				float2 uv : TEXCOORD0;
			};

			float4 _Color; 
			sampler2D _MainTexture;
			//build object
			v2f vertexFunction(appdata IN) {
				v2f OUT;
				OUT.position = UnityObjectToClipPos(IN.vertex);
				OUT.uv = IN.uv;

				return OUT;

			}

			//COlorrrrr ittttttt

			fixed4 fragmentFunction(v2f IN) : SV_Target{

				float4  textureColor = tex2D(_MainTexture, IN.uv);


				return textureColor * _Color;
			}

			//Vert Function
			//Build things

			//Fragment function
			//Color it in

			ENDCG

		}

	}
}