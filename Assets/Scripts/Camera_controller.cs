using UnityEngine;
using System.Collections;

public class Camera_controller : MonoBehaviour {
	float xPos, zPos;
	float CamSpeed = 0.3f; 
	void Start () {
	
	}

	void Update () {
		if (Input.GetMouseButton (1)) {
			xPos = CamSpeed * Input.GetAxis ("Mouse X");
			zPos = CamSpeed * Input.GetAxis ("Mouse Y");
			this.transform.Translate (xPos, 0, zPos, Space.World);
		}
	}
}
