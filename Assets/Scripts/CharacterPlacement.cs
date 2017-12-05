using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlacement : MonoBehaviour {

	public bool byDrawers = false;
	public bool byTV = false;
	public bool byPhoto = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "drawerArea"){
			byDrawers = true;
		}
		if (col.gameObject.name == "tvArea") {
			byTV = true;
		}

		if (col.gameObject.name == "photoArea") {
			byPhoto = true;
		}
	}

	void OnCollisionEnter(Collision col){
		Debug.Log (col.gameObject.name);
	}
}
