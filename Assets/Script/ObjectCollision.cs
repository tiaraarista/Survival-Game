using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour {

	//public AudioSource Musuh1;
	//public AudioSource Musuh2;
	//public AudioSource Musuh3;
	//public AudioSource Musuh4;

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "ObjectMusuh") {
			Debug.Log ("Collide!");
			AudioSource aud = gameObject.GetComponent<AudioSource> ();
			aud.Play ();
			col.gameObject.SetActive (true);
		}
	}
}
