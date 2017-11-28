using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlacement : MonoBehaviour {

	public bool byDrawers = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "drawers"){
			byDrawers = true;
		}
	}
}
