using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;   
    public Vector2 movement;
    public GameObject skinMask;
    private SpriteRenderer skin;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        skin = skinMask.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");  
    }
    private void FixedUpdate()
    {
        if(GameManager.Instance.gameState == GameState.GamePlay)
        {
            Move();
        }    
        
    }
    private void Move()
    {      
        if(movement  != Vector2.zero)
        {
            if (movement.x < 0)
            {
                skin.flipX = true;
            }
            else if (movement.x > 0)
            {
                skin.flipX = false;
            }
            rb.velocity = movement * moveSpeed;          
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }      
}
