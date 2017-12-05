using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoInteraction : MonoBehaviour {

	public GameObject character;
	//public Animator drawers;
	public Animator anim;

    public ParticleSystem particle;

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
            StartCoroutine(LookPhoto());
            StartCoroutine(LookPhotoOut());
            StartCoroutine(GameEnd());

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

        yield return new WaitForSeconds(6);
        anim.Play("PhotoZoomOut");
    }

    IEnumerator GameEnd()
    {

        yield return new WaitForSeconds(6);
        anim.Play("EndZoomOut");
    }

}
