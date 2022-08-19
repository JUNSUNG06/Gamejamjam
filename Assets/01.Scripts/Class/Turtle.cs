using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Turtle : MonoBehaviour
{
    [SerializeField]char _grade;
    string _name;
    int _helth;
    string _des;
    int _price;
    int _prob;
    public string Name{get => _name;}
    public Turtle(string grade, string name, int helth, string des, int price, int prob){

    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
