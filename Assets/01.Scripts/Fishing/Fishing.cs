using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Fishing : MonoBehaviour
{
    [SerializeField] private List<Turtle> turtles = new List<Turtle>();
    [SerializeField] private GameObject touchZoon; 
    [SerializeField] private Vector2 maxZoonPos;
    [SerializeField] private Vector2 minZoonPos;
    [SerializeField] private Turtle fishingTurtle = null;
    [SerializeField] private bool isFishing = false;
    [SerializeField] int turtleHp = 0;
    
    private void Start() 
    {
        SetTouchZoon();
    }

    private void Update() 
    {
        if(isFishing)
        {
            Fishingg();
        }
    }

    private void SetTouchZoon()
    {
        touchZoon.transform.position = new Vector2(UnityEngine.Random.Range(minZoonPos.x, maxZoonPos.x), 
            UnityEngine.Random.Range(minZoonPos.y, maxZoonPos.y));
            touchZoon.SetActive(true);
    }

    public void StartFishing()//에니메이션 이벤트
    {
        int probability = UnityEngine.Random.Range(0, 10);
        
        switch(probability)
        {
            case 0:
                fishingTurtle = turtles[0];
                break;
            case 1:
                fishingTurtle = turtles[1];
                break;
            case 2:
                fishingTurtle = turtles[2];
                break;
            case 3:
                fishingTurtle = turtles[3];
                break;
            case 4:
                fishingTurtle = turtles[4];
                break;
            case 5:
                fishingTurtle = turtles[5];
                break;
            case 6:
                fishingTurtle = turtles[6];
                break;
            case 7:
                fishingTurtle = turtles[7];
                break;
            case 8:
                fishingTurtle = turtles[8];
                break;
            case 9:
                fishingTurtle = turtles[9];
                break;
        }

        turtleHp = fishingTurtle.health;
        isFishing = true;
        Debug.Log(fishingTurtle.turtleName);
    }

    private void Fishingg()
    {
        Debug.Log("낚시 중");
        float currentFishingTime = 0;
        
        currentFishingTime += Time.deltaTime;

        if(Input.GetMouseButtonDown(0))
        {
            turtleHp--;
            Debug.Log("asd");
        }

        if(turtleHp == 0 && currentFishingTime < fishingTurtle.time)
        {
            Debug.Log("성공");
            isFishing = false;
            GameObject.Find("Player").GetComponent<Player>().AddFish(fishingTurtle);
        }
        else if(turtleHp != 0 && currentFishingTime >= fishingTurtle.time)
        {
            Debug.Log("실패");
            isFishing = false;
        }
    }
}
