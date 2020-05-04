using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour {
	Animation _animation;

	// Use this for initialization
	void Start () {
		_animation = GetComponentInChildren<Animation> ();

		string animationToPlay = "";
		switch (Random.Range (0, 3)) {
		case 0:
			animationToPlay = "Move1";
			break;
		case 1:
			animationToPlay = "Move2";
			break;
		case 3:
			animationToPlay = "Move3";
			break;
		default:
			animationToPlay = "Move1";
			break;
		}
		_animation ["Move1"].wrapMode = WrapMode.Loop;
		_animation.Play (animationToPlay);
		_animation [animationToPlay].normalizedTime = Random.value;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
