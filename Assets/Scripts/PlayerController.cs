using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//Declare our key variables
	public KeyCode left;
	public KeyCode right;

	//Our component for updating animations
	Animator anim;

	// Use this for initialization
	void Start () {
		//Set the key variables
		left = KeyCode.A;
		right = KeyCode.D;

		//Set the animator component
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetBool("isRunning", (Input.GetKey("a") || Input.GetKey("d")));

	}
}
