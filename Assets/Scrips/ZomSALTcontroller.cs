using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZomSALTcontroller : MonoBehaviour
{
    public float velocityX = 0;
    private Rigidbody2D rb;
    public float jumForce = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocityX, rb.velocity.y);
        
        rb.AddForce(Vector2.up * jumForce, ForceMode2D.Impulse);
        
    }
}
