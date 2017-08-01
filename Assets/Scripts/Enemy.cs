using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

	public Transform playerLoc;
	NavMeshAgent agent;

	public void Awake(){
		agent = GetComponent<NavMeshAgent>();


	}

	void Update(){
		gameObject.GetComponent<NavMeshAgent>().SetDestination(playerLoc.position);
	
	}
}
