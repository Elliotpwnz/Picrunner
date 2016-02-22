using UnityEngine;
using System.Collections;

public class feetCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	//Our collision functions
	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.layer == LayerMask.NameToLayer("platform")){
			transform.parent.GetComponent<PlayerController>().isGrounded = true;
		}
	}
	void OnTriggerExit2D(Collider2D collider)
	{
		if (collider.gameObject.layer == LayerMask.NameToLayer("platform")){
			transform.parent.GetComponent<PlayerController>().isGrounded = false;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
