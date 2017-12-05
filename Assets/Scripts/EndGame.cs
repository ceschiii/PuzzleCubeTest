using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public Animator anim;
    AudioSource audioSource;
    public ParticleSystem particle;
    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        audioSource.Play();
        anim.Play("EndZoomOut");
        particle.Stop(true, ParticleSystemStopBehavior.StopEmitting);
    }
}