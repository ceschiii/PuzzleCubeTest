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
            audioSource.Play();
            
            StartCoroutine(LookDrawer());
            StartCoroutine(LookDrawerOut());
        }
        //Debug.Log("Pressed left click.");
    }
    IEnumerator LookDrawer()
    {
        yield return new WaitForSeconds(1.5f);
        anim.Play("DrawerZoom");
        particle.Stop(true, ParticleSystemStopBehavior.StopEmitting);
       
    }
    IEnumerator LookDrawerOut()
    {

        yield return new WaitForSeconds(9);
        anim.Play("DrawerZoomOut");
        newparticle.Play();
}
}
