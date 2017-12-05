using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawer : MonoBehaviour {

	public GameObject character;
    public Animator drawers;
    public Animator anim;
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
            StartCoroutine(LookDrawer());
            StartCoroutine(LookDrawerOut());
        }
        //Debug.Log("Pressed left click.");
    }
    IEnumerator LookDrawer()
    {
        yield return new WaitForSeconds(1);
        anim.Play("DrawerZoom");

    }
    IEnumerator LookDrawerOut()
    {

        yield return new WaitForSeconds(4);
        anim.Play("DrawerZoomOut");
    }
}
