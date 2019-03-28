using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_audio : MonoBehaviour {
    public AudioSource MainAudio;
    public AudioClip one;
    public AudioClip two;
    public AudioClip three;
    public bool canPlay = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("1") == true && canPlay == true)
        {
            MainAudio.clip = one;
            MainAudio.Play();
            canPlay = false;
            StartCoroutine(PlayerSound());
        }
        if (Input.GetKeyDown("2") == true && canPlay == true)
        {
            MainAudio.clip = two;
            MainAudio.Play();
            canPlay = false;
            StartCoroutine(PlayerSound());
        }
        if (Input.GetKeyDown("3") == true && canPlay == true)
        {
            MainAudio.clip = three;
            MainAudio.Play();
            canPlay = false;
            StartCoroutine(PlayerSound());
        }
    }

    private IEnumerator PlayerSound()
    {
        yield return new WaitForSecondsRealtime(5);
        canPlay = true;
    }
}
