using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	[SerializeField]
	float _secondsToWin = 180.0f;

	static bool _hasPlayerWon = false;
	public static bool HasPlayerWon {
		get { return _hasPlayerWon; }
	}

	PlayerHealth _playerHealth;

	// Use this for initialization
	void Start () {
		Invoke ("Checkwin", _secondsToWin);

		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		_playerHealth = player.GetComponent<PlayerHealth> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CheckhWin(){
		if(!_playerHealth.isDeath()){
			_hasPlayerWon = true;
		}
	}
}
