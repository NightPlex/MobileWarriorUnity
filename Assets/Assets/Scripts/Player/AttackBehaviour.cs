using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBehaviour : StateMachineBehaviour {

	private void OnStateExit(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex) {
		animator.GetComponentInChildren<Attack>().CanAttack = true;
	}
}
