using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DisableRagdoll ();
	}
	void DisableRagdoll(){
		Rigidbody[] allRigidbodies = GetComponentsInChildren<Rigidbody> ();
		foreach (Rigidbody r in allRigidbodies) {
			r.isKinematic = true;
		}
	}

	void EnableRagdoll(){
		Rigidbody[] allRigidbodies = GetComponentsInChildren<Rigidbody> ();
		foreach (Rigidbody r in allRigidbodies) {
			r.isKinematic = false;
		}
	}

	public void onDeath(){
		EnableRagdoll ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
