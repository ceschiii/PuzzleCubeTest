using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoInteraction : MonoBehaviour {

	public GameObject character;
	//public Animator drawers;
	public Animator anim;
    AudioSource audioSource;
    public ParticleSystem newparticle;
    public ParticleSystem particle;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		if (character.GetComponent<CharacterPlacement> ().byPhoto) {
            //drawers.SetBool("Open", true);
            audioSource.Play();
            StartCoroutine(LookPhoto());
            StartCoroutine(LookPhotoOut());


        }
        //Debug.Log("Pressed left click.");
    }

    IEnumerator LookPhoto()
    {
        yield return new WaitForSeconds(0.5f);
        anim.Play("PhotoZoom");
        particle.Stop(true, ParticleSystemStopBehavior.StopEmitting);
    }

    IEnumerator LookPhotoOut()
    {

        yield return new WaitForSeconds(8);
        anim.Play("PhotoZoomOut");
        newparticle.Play();
    }



}
