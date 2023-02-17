using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello, world!");
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Getting the rigidbody component of the sprite - vector 3 since using 3 values (x,y,z) 
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 10, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(10, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-10, 0, 0);
        }
    }
}
