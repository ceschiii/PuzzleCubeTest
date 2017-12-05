﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawer : MonoBehaviour {

	public GameObject character;
    public Animator drawers;
    public Animator anim;
    public ParticleSystem particle;
    public ParticleSystem newparticle;
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
        yield return new WaitForSeconds(0.5f);
        anim.Play("DrawerZoom");
        particle.Stop(true, ParticleSystemStopBehavior.StopEmitting);

    }
    IEnumerator LookDrawerOut()
    {

        yield return new WaitForSeconds(6);
        anim.Play("DrawerZoomOut");
        newparticle.Play();
}
}
