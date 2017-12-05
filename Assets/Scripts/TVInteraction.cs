using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVInteraction : MonoBehaviour {

	public GameObject character;
	//public Animator drawers;
	public Animator anim;
    public ParticleSystem particle;
    public ParticleSystem newparticle;
    AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		if (character.GetComponent<CharacterPlacement> ().byTV) {
            StartCoroutine(LookTV());
            StartCoroutine(LookTVOut());

        }
		//Debug.Log("Pressed left click.");
	}
    IEnumerator LookTV()
    {
        audioSource.Play();

        yield return new WaitForSeconds(0.5f);
        anim.Play("TVzoom");


        particle.Stop(true, ParticleSystemStopBehavior.StopEmitting);
    }
    IEnumerator LookTVOut()
    {

        yield return new WaitForSeconds(6);
        anim.Play("TVzoomOut");
        newparticle.Play();
    }


}
