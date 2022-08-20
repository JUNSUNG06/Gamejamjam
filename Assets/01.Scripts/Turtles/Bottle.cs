using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
     public Turtle info = null;
    private void Awake() 
    {
        if(info == null)
        {
            info = new Turtle(Turtle.Garde.D, "Bottle", 400, Turtle.descriptionList[6], 100, 3);
        }
    }
}
