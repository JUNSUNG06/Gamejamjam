using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sardine : MonoBehaviour
{
    public Turtle info = null;
    private void Awake() 
    {
        if(info == null)
        {
            info = new Turtle(Turtle.Garde.C, "Sardine", 200, Turtle.descriptionList[8], 100, 5);
        }
    }
}
