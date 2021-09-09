
// ReSharper disable once RedundantUsingDirective
using System;
// ReSharper disable once RedundantUsingDirective
using System.Collections;
// ReSharper disable once RedundantUsingDirective
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocityX = 10;
    private Rigidbody2D rb;
    public float jumForce = 50;
    private Animator _animator;
    

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
      
            


            rb.velocity = new Vector2(velocityX, rb.velocity.y);

            if (Input.GetKeyUp(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumForce, ForceMode2D.Impulse);
            }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("head")){
            
            Destroy(this.gameObject);
        }
    }
    

     
}

