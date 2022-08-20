using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caretta : MonoBehaviour
{
     public Turtle info = null;
    private void Awake() 
    {
        if(info == null)
        {
            info = new Turtle(Turtle.Garde.B, "Caretta", 800, Turtle.descriptionList[2], 100, 8);
        }
    }
}
