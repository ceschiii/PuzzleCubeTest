﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour {

	float yPosition;

	// Use this for initialization
	void Start () {

		yPosition = transform.position.y;
		
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnMouseDrag()
	{

		float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

		//This lets you click on the object and drag it around:
		Vector3 tempVector = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen ));

		transform.position = new Vector3 (tempVector.x, yPosition, tempVector.z);

	}

}
