using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class gravityScript : MonoBehaviour
{
    public float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is our GetAxisRaw input 
        float v = Input.GetAxisRaw("Vertical") * speed;
        //Just calling the Rigidbody2D component to change its Velocity value
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v);

    }
}
