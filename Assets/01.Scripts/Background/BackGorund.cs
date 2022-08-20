using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGorund : MonoBehaviour
{
    [SerializeField] float cludeSpeed;
    [SerializeField] float oceanSpeed;
    [SerializeField] Material cludeMat;
    [SerializeField]Material oceanMat;
    void Update()
    {
        oceanMat.mainTextureOffset += new Vector2 (oceanSpeed*Time.deltaTime,0); 
        cludeMat.mainTextureOffset += new Vector2 (cludeSpeed*Time.deltaTime,0); 
    }
}
