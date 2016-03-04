using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

	public float cameraSpeed;

	// Use this for initialization
	void Start () {
		cameraSpeed = 2.5f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(cameraSpeed * Time.deltaTime,0,0));
	}
}
