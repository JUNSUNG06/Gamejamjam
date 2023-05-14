using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    private void Update() 
    {
        Move();
    }

    private void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        Vector2 moveVec = new Vector2(h, 0);

        rb.velocity = moveVec * speed;

        if(h == 1)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if(h == -1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
    
    private void ChangeScene()
    {
        if(transform.position.x >= 9)
        {
            
        }
    }
}
