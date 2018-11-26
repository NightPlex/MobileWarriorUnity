using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy {

	public override void Update() {
		HandleMoveAi();
		Attack();
	}

	//User for initialization
	protected override void Init() {
		base.Init();
	}
}
