using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomZoom : MonoBehaviour {
    public Animator anim;
    public Animator wallAnim;
    public GameObject wall;
    BoxCollider collider;
    AudioSource audioSource;

    // Use this for initialization
    void Start () {
        collider = GetComponent<BoxCollider>();
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        audioSource.Play();
        StartCoroutine(ByeByeWall());
    }

    IEnumerator ByeByeWall()
    {
        yield return new WaitForSeconds(5);
        anim.Play("CameraZoom");
        
        wallAnim.Play("MainWallOpen");
      //  wall.SetActive(false);
        collider.enabled = false;
    }
}
