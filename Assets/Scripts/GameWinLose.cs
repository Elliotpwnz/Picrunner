using UnityEngine;
using System.Collections;

public class GameWinLose : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameStatus.gameWin) {
			gameObject.GetComponent<UnityEngine.UI.Text> ().text = "YOU WIN!";
		} else {
			gameObject.GetComponent<UnityEngine.UI.Text> ().text = "YOU LOSE!";
		}
	}
}
