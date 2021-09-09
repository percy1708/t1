using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
   // public Transform play;
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var x= playerTransform.position.x;
       
        var y = transform.position.y;
        transform.position = new Vector3(x,y, transform.position.z);
    }
}
