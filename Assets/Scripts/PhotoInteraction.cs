using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoInteraction : MonoBehaviour {

	public GameObject character;
	//public Animator drawers;
	public Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		if (character.GetComponent<CharacterPlacement> ().byPhoto) {
			//drawers.SetBool("Open", true);

		}
		//Debug.Log("Pressed left click.");
	}

}
