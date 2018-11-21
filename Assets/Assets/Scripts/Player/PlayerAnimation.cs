using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

	private Animator _animatorPlayer;
	
	void Start () {
		_animatorPlayer = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	public void Move (float move) {
		_animatorPlayer.SetFloat("Move", Mathf.Abs(move));
	}

	public void Jump() {
		_animatorPlayer.SetTrigger("triggerJump");
	}

	public void Attack() {
		_animatorPlayer.SetTrigger("triggerAttack");
	}
}
