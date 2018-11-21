using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MossGiant : Enemy, IDamageable {

	private void Start() {
		throw new System.NotImplementedException();
	}

	public override void Attack() {
		base.Attack();
	}

	public override void Update() {

		if (Vector3.Distance(transform.position, pointA.position) <= 0) {
			Debug.Log("We are entered the transform");
		} else if (Vector3.Distance(transform.position, pointB.position) <= 0) {
			Debug.Log("We have left the transform");
		}
		
	}

	public void Damage() {
		throw new System.NotImplementedException();
	}
}
