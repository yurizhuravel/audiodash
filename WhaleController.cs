﻿using UnityEngine;
using System.Collections;

public class WhaleController : MonoBehaviour {

	public float Speed;		

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (0, 0, Speed * Time.deltaTime);
	
	}
}
