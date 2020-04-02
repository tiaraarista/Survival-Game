using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour {

	public AudioSource Musuh1;
	public AudioSource Musuh2;
	public AudioSource Musuh3;
	public AudioSource Musuh4;

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "ObjectMusuh") {
			Debug.Log ("Musuh1 Killed!");
			Musuh1.GetComponent<AudioSource> ();
			Musuh1.Play ();
			col.gameObject.SetActive (false);
		}if (col.gameObject.tag == "ObjectMusuh2") {
			Debug.Log ("Musuh2 Killed!");
			Musuh2.GetComponent<AudioSource> ();
			Musuh2.Play ();
			col.gameObject.SetActive (false);
		}if (col.gameObject.tag == "ObjectMusuh3") {
			Debug.Log ("Musuh3 Killed!");
			Musuh3.GetComponent<AudioSource> ();
			Musuh3.Play ();
			col.gameObject.SetActive (false);
		}if (col.gameObject.tag == "ObjectMusuh4") {
			Debug.Log ("Musuh4 Killed!");
			Musuh4.GetComponent<AudioSource> ();
			Musuh4.Play ();
			col.gameObject.SetActive (false);
		}
	}
}
