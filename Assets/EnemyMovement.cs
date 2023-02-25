using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class EnemyMovement : MonoBehaviour
{
    public float Speed = -3f;
    Transform LeftRestrictOne,RightRestrictOne;
    Vector3 localScale;
    bool MovingLeft = true;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        LeftRestrictOne = GameObject.Find("LeftRestrictOne").GetComponent<Transform>();
        RightRestrictOne = GameObject.Find("RightRestrictOne").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < LeftRestrictOne.position.x)
        {
            MovingLeft = false;
        }
        if (transform.position.x > RightRestrictOne.position.x)
        {
            MovingLeft = true;
        }
        if (MovingLeft)
        {
            moveLeft();
        }
        else
        {
            moveRight();
        }
    }
    void moveLeft()
    {
        MovingLeft = true;
        localScale.x = 1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * Speed, rb.velocity.y);
    }
    void moveRight()
    {
        MovingLeft = false;
        localScale.x = -1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * Speed, rb.velocity.y);
    }
}
