// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/ShardShader" {
	//Vars
	Properties{
		_MainTexture("Main Color (RBG) Hello!", 2D) = "white" {}
		_Color("Green", Color) = (1,1,1,1)

		_DissolveTexture("Cheese", 2D) = "white" {}
		_DissolveAmount("Amount to cut out", Range(0, 1)) = .1

		_ExtrudeAmount("Extrude Amount", Range(-0.1, .4)) = .3
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
				float3 normal : NORMAL;
			};

			struct v2f {
				float4 position : SV_POSITION;
				float2 uv : TEXCOORD0;
			};

			float4 _Color; 
			sampler2D _MainTexture;

			sampler2D _DissolveTexture;
			float _DissolveAmount;

			float _ExtrudeAmount;
			
			//build object
			v2f vertexFunction(appdata IN) {
				v2f OUT;
				IN.vertex.xyz += IN.normal.xyz * _ExtrudeAmount * sin(_Time.z);

				OUT.position = UnityObjectToClipPos(IN.vertex);
				OUT.uv = IN.uv;

				return OUT;

			}

			//COlorrrrr ittttttt

			fixed4 fragmentFunction(v2f IN) : SV_Target{

				float4  textureColor = tex2D(_MainTexture, IN.uv);
				float4 dissolveColor = tex2D(_DissolveTexture, IN.uv);

				clip(dissolveColor.rgb - _DissolveAmount);

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