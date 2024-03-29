﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour 
{

	public Transform target;

	public float smoothSpeed = 0.125f;
	public Vector3 offset;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if(target == null)
		{
			Debug.Log("Target is not assigned");
			return;
		}

		target = GameObject.FindWithTag("Player").transform;

		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
		transform.position = smoothPosition;
	}
}
