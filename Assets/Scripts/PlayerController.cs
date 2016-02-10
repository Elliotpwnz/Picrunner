using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//Declare our key variables
	public KeyCode left;
	public KeyCode right;

	public bool facingRight;
	public bool isMoving;
	public bool isGrounded; //Restricts jumping while in air
	public float moveSpeed; //The player's move speed
	public float jumpForce; //The player's upward thrust when jumping

	//Our component for updating animations
	Animator anim;

	//Our rigidbody component
	Rigidbody2D myRgbd;

	// Use this for initialization
	void Start () {
		//Set the animator component
		anim = GetComponent<Animator>();

		//Set the rigidbody component
		myRgbd = GetComponent<Rigidbody2D>();

		//Set misc variables
		facingRight = true;
		isMoving = false;
		moveSpeed = 3.0f;
		jumpForce = 3.0f;
		isGrounded = false;
	}

	//Our player movement function
	void movePlayer(bool facingRight){
		if (facingRight) {
			myRgbd.velocity = new Vector2 (moveSpeed, myRgbd.velocity.y);
		} else {
			myRgbd.velocity = new Vector2 (-1 * moveSpeed, myRgbd.velocity.y);
		}
	}

	//Our player jump function
	void playerJump(){
		myRgbd.velocity = new Vector2 (myRgbd.velocity.x, jumpForce);
	}

	// Update is called once per frame
	void Update () {

		//Check and set the jumping animation
		anim.SetBool("isJumping", !isGrounded);

		//Checking and responding to key input
		// Left and Right movement key inputs
		if (Input.GetKey ("a")) { //If the 'a' key is held
			isMoving = true;
			facingRight = false;
			anim.SetBool ("isRunning", true);
			transform.localRotation = Quaternion.Euler(0, 180, 0);
		} else if (Input.GetKey ("d")) { //If the 'd' key is held
			isMoving = true;
			facingRight = true;
			anim.SetBool ("isRunning", true);
			transform.localRotation = Quaternion.Euler(0, 0, 0);
		} else {
			isMoving = false;
			anim.SetBool ("isRunning", false);
		}

		//Jumping key input
		if (Input.GetKey ("space") && isGrounded) {
			playerJump ();
		}

		if (isMoving) {
			movePlayer (facingRight);
		} else {
			myRgbd.velocity = new Vector2 (0, myRgbd.velocity.y); //Make sure the player doesn't slide
		}
	}
}
