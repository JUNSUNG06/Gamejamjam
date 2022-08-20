using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fish{
    public Fish(string Name, int ClickTime){
        name= Name;
        clickTime = ClickTime;
    }
    public String name;
    public int clickTime;
}
public class Fishing : MonoBehaviour
{
    public static Fishing Instance = null;
    int time;
        Fish[] fishs = new Fish[10];
        bool bite = false;

    private void Start() {
        fishs[0] = new Fish("올리브 들리 바다 거북이", 10);
        fishs[1] = new Fish("매부리 바다 거북이", 9);
        fishs[2] = new Fish("붉은 바다 거북이", 8);
        fishs[3] = new Fish("장수 거북이", 7);
        fishs[4] = new Fish("푸른 바다 거북이", 6);
        fishs[5] = new Fish("신발 쓰레기", 5);
        fishs[6] = new Fish("병", 4);
        fishs[7] = new Fish("책", 3);
        fishs[8] = new Fish("정어리", 2);
        fishs[9] = new Fish("고등어", 1);
    }
        
    public void FishingStart(){
        int time;
        switch(UnityEngine.Random.Range(1,11)){
            case 1:
            case 2:
            case 3:
            case 4:
                time = UnityEngine.Random.Range(1,6);
                StartCoroutine(waitFish(time));
                break;
            case 5:
            case 6:
            case 7:
                time = UnityEngine.Random.Range(6,11);
                StartCoroutine(waitFish(time));
                break;
            case 8:
            case 9:
                time = UnityEngine.Random.Range(11,16);
                StartCoroutine(waitFish(time));
                break;
            case 10:
                time = UnityEngine.Random.Range(16,21);
                StartCoroutine(waitFish(time));
                break;
        }
    }
    IEnumerator waitFish(int time){
        yield return new WaitForSeconds(time);
        Fish cacheFish = fishs[UnityEngine.Random.Range(0,10)];
        StartCoroutine(waitClickTime());
    }
    IEnumerator waitClickTime(){
        yield return new WaitForSeconds(3f);
        
    }

    void Update()
    {
        if(bite){
            
        }
    }
}
