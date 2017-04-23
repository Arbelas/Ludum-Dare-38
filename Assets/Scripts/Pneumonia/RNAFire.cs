﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNAFire : MonoBehaviour {

	public GameObject projectile;

	public void Fire() {
		//Debug.Log("Fire RNA");		
		projectile.transform.eulerAngles = transform.eulerAngles;
		projectile.transform.position = transform.position;
		GameObject temp = Instantiate(projectile);
		temp.transform.SetParent(GameObject.Find("RNA").transform);
	}
}
