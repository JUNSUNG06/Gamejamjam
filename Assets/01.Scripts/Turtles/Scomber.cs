using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scomber : MonoBehaviour
{
    public Turtle info = null;
    private void Awake() 
    {
        if(info == null)
        {
            info = new Turtle(Turtle.Garde.C, "Scomber", 100, Turtle.descriptionList[9], 100, 5);
        }
    }
}
