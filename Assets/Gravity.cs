﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
	public float _gravity = 2f;
	private TimeManager localTime;
	private Rigidbody2D rb;
	[SerializeField] private bool isGrounded = false;


	// Use this for initialization
	void Start () {
		localTime = GameObject.Find ("TimeManager").GetComponent<TimeManager> ();
		rb = GetComponent<Rigidbody2D> ();
	}
	void FixedUpdate()
	{	
		Vector2 newPosition = new Vector2(transform.position.x, transform.position.y - _gravity * localTime.localDeltaTime());
		rb.MovePosition(newPosition);

	}
}
