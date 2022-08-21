using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager
{
    public static SoundManager Instance =null;
    AudioSource audioSource;
    public AudioClip getItemSound;
    public AudioClip failSound;
    public AudioClip throwSound;
    public AudioClip pullSound;
    public AudioClip processingSound;
    public AudioClip sellSound;
    public SoundManager(AudioClip[] a){
        audioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        getItemSound = a[0];
        failSound = a[1];
        throwSound = a[2];
        pullSound = a[3];
        processingSound = a[4];
        sellSound = a[5];
    }
    public void SetSound(AudioClip audio){
            audioSource.clip = audio;
            audioSource.Play();
    }
    
}