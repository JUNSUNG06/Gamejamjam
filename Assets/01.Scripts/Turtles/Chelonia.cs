using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chelonia : MonoBehaviour
{
     public Turtle info = null;
    private void Awake() 
    {
        if(info == null)
        {
            info = new Turtle(Turtle.Garde.B, "Chelonia", 600, Turtle.descriptionList[4], 100, 6);
        }
    }
}
