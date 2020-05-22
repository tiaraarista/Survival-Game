using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {
	[SerializeField]
	float _attackDelay = 1.0f;

	[SerializeField]
	int _damageDealt = 5;

	float _nextTimeAttackIsAllowed = -1.0f;

	void OnTriggerStay(Collider other){
		if (other.tag == "Player" && Time.time >= _nextTimeAttackIsAllowed) {
			PlayerHealth _playerHealth = other.GetComponent<PlayerHealth> ();
			if (_playerHealth._currentHealth > 0) {
				_playerHealth.Damage (_damageDealt);
				_nextTimeAttackIsAllowed = Time.time + _attackDelay;
			} else {
				Animation anim = GetComponentInChildren<Animation> ();
				anim.Stop ();
				Destroy (GetComponentInParent<CharacterController> ());
				Destroy (GetComponentInParent<EnemyMovement> ());
				Destroy (GetComponentInParent<EnemyAnimation> ());
				Destroy (GetComponentInParent<EnemyAttack> ());
			}
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
