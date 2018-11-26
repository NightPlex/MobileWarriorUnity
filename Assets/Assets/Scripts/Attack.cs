using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	public bool CanAttack = true;
	
	private void OnTriggerEnter2D(Collider2D other) {
		IDamageable hit = other.gameObject.GetComponent<IDamageable>();
		Debug.Log(other.name);
		if (hit != null && CanAttack) {
			hit.Damage();
			CanAttack = false;
		}
	}
	
	
}
