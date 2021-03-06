﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour {

	public float speed;
	public bool canMove = true;

	// Use this for initialization
	void Start() {
		Destroy(gameObject, 50);
	}

	// Update is called once per frame
	void Update() {
		//Debug.Log(direction);
		if(canMove) transform.Translate(new Vector2(0, 1) * (speed / 100) * Time.deltaTime);
	}

	public void Freeze(Transform t, float v) {
		Freeze(t);
		Destroy(gameObject, v);
	}

	public void Freeze(Transform t) {
		canMove = false;
		transform.SetParent(t);
		//transform.lossyScale = new Vector3(0.5, 0.5, 1);
		//GetComponent<Collider2D>().isTrigger = false;
		Destroy(GetComponent<Collider2D>());
	}
}
