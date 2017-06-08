using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSoundPlayer : MonoBehaviour {

    private AudioSource audioSource;
    [SerializeField]
    private List<AudioClip> soundClips = new List<AudioClip>();
    [SerializeField]
    private float soundTimerDelay = 3f;
    private float soundTimer;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        //increment timer
        soundTimer += Time.deltaTime;

        if (soundTimer >= soundTimerDelay)
        {
            soundTimer = 0f; //reset timer
            AudioClip randomSound = soundClips[Random.Range(0,soundClips.Count)]; //get random soundclip
            audioSource.PlayOneShot(randomSound); //have the AudioSource play it!
        }
	}
}
