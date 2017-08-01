using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

	public GameObject Player;
	public GameObject EG;
	public GameObject [] Contestants;
	public Text egText;

	void Awake(){

		InvokeRepeating ("NewTarget", 5f, 15f);
	}
			public void NewTarget(){
		Debug.Log ("net target");
	}



	public void GameOver(){
		egText.text = "Final Standings";
		EG.SetActive (true);
		Player.GetComponent<MeshRenderer> ().enabled = false;
		Player.GetComponent<Movement> ().speed = 0f;
		Player.GetComponent<Movement> ().gravity = 0f;
		foreach (GameObject contestant in Contestants) {
			contestant.SetActive (false);
		}
	}
}
