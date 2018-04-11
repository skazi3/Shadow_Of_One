using UnityEngine;
using System.Collections;

public class CameraFacing : MonoBehaviour
{
	public Camera cam1, cam2;

	void Update()
	{
		transform.LookAt(transform.position + cam1.transform.rotation * Vector3.forward,
			cam1.transform.rotation * Vector3.up);
		
		//transform.LookAt(transform.position + cam2.transform.rotation * Vector3.forward,
			//cam2.transform.rotation * Vector3.up);
	}
}