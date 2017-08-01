using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lance : MonoBehaviour {
	
	public int kill_score;
	public Text kill_Text;
	public string character_Name;
	public GameObject test;
	public Audio_Manager aM;
	public Manager man;
	public Vector3 spawnPoint;

	void Awake(){
		kill_Text.text = character_Name + ": " + kill_score.ToString ();
		spawnPoint = gameObject.transform.position;
	}

	public void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player") {
			
			aM.PlaySfx (0);
			collision.gameObject.transform.position = spawnPoint;
			kill_score++;
			kill_Text.text = character_Name + ": " + kill_score.ToString ();
			CheckIfVictory ();

		}
		if (collision.gameObject.tag == "Contestant") {
			aM.PlaySfx (0);
			Instantiate (test,gameObject.transform);
			collision.gameObject.transform.position = spawnPoint;
			kill_score++;
			kill_Text.text = character_Name + ": " + kill_score.ToString ();
			CheckIfVictory ();
		}
	}
	public void CheckIfVictory(){

		if (kill_score >= 10) {
		
			man.GameOver ();
		}
	}


}
