using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Olive : MonoBehaviour
{
    public Turtle info = null;
    private void Awake() 
    {
        if(info == null)
        {
            info = new Turtle(Turtle.Garde.A, "Olive", 1000, Turtle.descriptionList[0], 100, 10);
        }
    }
}
