using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : Enemy, IDamageable {

	public void Damage() {
		
	}

	//User for initialization
	protected override void Init() {
		base.Init();
	}
	
	public override void Update() {
		HandleMoveAi();
	}
}
