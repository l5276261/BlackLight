using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	private float _moveSpeed = 10.0f;
	private float _endZ = -20.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z < _endZ) {
			transform.Translate (Vector3.forward*_moveSpeed*Time.deltaTime);
		}
	}
}
