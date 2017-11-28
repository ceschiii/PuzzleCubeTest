using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawer : MonoBehaviour {

	public GameObject character;
	public Animator drawers;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}
    void OnMouseDown()
    {
		if (character.GetComponent<CharacterPlacement> ().byDrawers) {
			drawers.SetBool("Open", true);
		}
        //Debug.Log("Pressed left click.");
    }
}
