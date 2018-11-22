using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour {

	private Animator _animator;
	
	// Use this for initialization
	void Start () {
		_animator = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public bool IdleState() {
		return _animator.GetCurrentAnimatorStateInfo(0).IsName("idle");
	}

	public void TriggerIdle() {
		_animator.SetTrigger("Idle");
	}
}
