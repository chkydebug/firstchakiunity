﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {
	public Transform obj;
	public Vector3 offset;

	
	// Update is called once per frame
	void Update () {
		transform.position = obj.position+offset;
		
	}
}
