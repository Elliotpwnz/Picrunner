using UnityEngine;
using System.Collections;

public class feetCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	//Our collision functions
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.gameObject.layer == LayerMask.NameToLayer("platform")){
			transform.parent.GetComponent<PlayerController>().isGrounded = true;
		}
	}
	void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.collider.gameObject.layer == LayerMask.NameToLayer("platform")){
			transform.parent.GetComponent<PlayerController>().isGrounded = false;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
