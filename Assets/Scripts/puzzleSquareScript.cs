using UnityEngine;
using System.Collections;

public class puzzleSquareScript : MonoBehaviour {

	//Defines whether the puzzle square contains a hidden block.
	public bool hiddenBlock;

	//Our renderer component
	Renderer rend; 

	// Use this for initialization
	void Start () {
		//This square contains a hidden block
		hiddenBlock = true;

		//Our renderer component
		rend = GetComponent<Renderer> ();
	}

	//If the game object is clicked
	void OnMouseOver(){
		if (Input.GetMouseButtonDown(0) && hiddenBlock) {
			GameObject theBlock = (GameObject)Instantiate (Resources.Load ("platform"));
			theBlock.transform.localScale = transform.localScale;
			theBlock.transform.position = transform.position;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
