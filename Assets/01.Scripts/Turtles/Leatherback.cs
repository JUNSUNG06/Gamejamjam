using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leatherback : MonoBehaviour
{
    public Turtle info = null;
    private void Awake() 
    {
        if(info == null)
        {
            info = new Turtle(Turtle.Garde.B, "Leatherback", 700, Turtle.descriptionList[3], 100, 7);
        }
    }
}
