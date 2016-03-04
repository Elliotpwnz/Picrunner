using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//We switch to the main scene
		if (Input.GetMouseButtonDown (0)) {

			print(Application.loadedLevel);
			DontDestroyOnLoad(GameObject.Find ("bgm"));
			Application.LoadLevel("MainScene");
			print(Application.loadedLevel);
		}
	}
}
