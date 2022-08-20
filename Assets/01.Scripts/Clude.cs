using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clude : MonoBehaviour
{
    [SerializeField]Collider2D seaSize;
    private void Start() {
        StartCoroutine(waitTime());
        }
    IEnumerator waitTime(){
        yield return new WaitForSeconds(Random.Range(1f,3f));
        
    }
}
