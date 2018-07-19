using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class thumbInteraction : MonoBehaviour {

    public AudioClip Clips;
    public AudioSource Cli;

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Cli.Play();

        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = Clips;

        audio.Play();
    }
}
