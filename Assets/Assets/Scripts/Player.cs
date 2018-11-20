using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField]
	private float _jumpForce = 5.0f;
	[SerializeField]
	private LayerMask _layerMask;
	private Rigidbody2D _rigid;
	[SerializeField]
	private float _moveSpeed = 3.0f; 
	private PlayerAnimation _playerAnimation;
	private SpriteRenderer _spriteRenderer;
	
	void Start () {
		_rigid = GetComponent<Rigidbody2D>();
		_playerAnimation = GetComponent<PlayerAnimation>();
		_spriteRenderer = GetComponentInChildren<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		Attack();
	}

	private void FixedUpdate() {
		Move();
	}

	private void Move() {
		float horizontalInput = Input.GetAxisRaw("Horizontal");

		Flip(horizontalInput);
		
		_playerAnimation.Move(horizontalInput);
		Debug.DrawRay(transform.position, Vector2.down, Color.green);
		if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()) {
			_rigid.velocity = new Vector2(_rigid.velocity.x, _jumpForce);
			_playerAnimation.Jump();
		}
		_rigid.velocity = new Vector2(horizontalInput * _moveSpeed, _rigid.velocity.y);
	}

	private void Attack() {
		if (Input.GetMouseButtonDown(0) && IsGrounded()) {
			_playerAnimation.Attack();
		}
	}

	private bool IsGrounded() {
		return Physics2D.Raycast(transform.position, Vector2.down, 1.0f, _layerMask.value).collider != null;
	}

	private void Flip(float horizontalInput) {
		if (horizontalInput > 0) {
			_spriteRenderer.flipX = false;
		} else if (horizontalInput < 0) {
			_spriteRenderer.flipX = true;
		}
	}
}
