using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager
{
    public static SoundManager Instance =null;
    AudioSource audioSource;
    public AudioClip processingSound;
    public SoundManager(AudioClip a){
        audioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        processingSound =a;
    }
    public void SetSound(AudioClip audio){
            audioSource.clip = audio;
            audioSource.Play();
    }
    
}