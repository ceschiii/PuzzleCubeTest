using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomZoom : MonoBehaviour {
    public Animator anim;
    public GameObject wall;
    BoxCollider collider;

	// Use this for initialization
	void Start () {
        collider = GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        anim.Play("CameraZoom");
        StartCoroutine(ByeByeWall());
    }

    IEnumerator ByeByeWall()
    {
        yield return new WaitForSeconds(1.5f);
        wall.SetActive(false);
        collider.enabled = false;
    }
}
