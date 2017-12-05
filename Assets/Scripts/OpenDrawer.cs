using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawer : MonoBehaviour {

	public GameObject character;
    public Animator drawers;
    public Animator anim;
    public ParticleSystem particle;
    AudioSource audioSource;
    public ParticleSystem newparticle;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        
    }
	
	// Update is called once per frame
	void Update () {


	}
    void OnMouseDown()
    {
		if (character.GetComponent<CharacterPlacement> ().byDrawers) {
            drawers.SetBool("Open", true);
            anim.Play("DrawerZoom");
            StartCoroutine(LookDrawer());
            StartCoroutine(LookDrawerOut());
        }
        //Debug.Log("Pressed left click.");
    }
    IEnumerator LookDrawer()
    {
        yield return new WaitForSeconds(0.5f);
        
        particle.Stop(true, ParticleSystemStopBehavior.StopEmitting);
        audioSource.Play();
    }
    IEnumerator LookDrawerOut()
    {

        yield return new WaitForSeconds(8);
        anim.Play("DrawerZoomOut");
        newparticle.Play();
}
}
