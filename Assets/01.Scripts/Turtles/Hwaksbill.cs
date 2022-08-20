using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hwaksbill : MonoBehaviour
{
    public Turtle info = null;
    private void Awake() 
    {
        if(info == null)
        {
            info = new Turtle(Turtle.Garde.A, "Hwaksbill", 900, Turtle.descriptionList[1], 100, 9);
        }
    }
}
