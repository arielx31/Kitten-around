using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    private Vector3 SpawnPoint;
    bool OnGround;
    public Transform GroundCheck;
    public LayerMask GroundLayer;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPoint = this.transform.position;
        Debug.Log(SpawnPoint);
    }

    // Update is called once per frame
    void Update()
    {
        OnGround = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, GroundLayer);
        Rigidbody2D body = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.UpArrow) && OnGround)
        {
            body.velocity.Set(body.velocity.x, 0);
            body.AddRelativeForce(new Vector2(0, 1000));
            OnGround = false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log($"Before: {body.velocity}");
            body.AddRelativeForce(new Vector2(25, 0));
            Debug.Log($"After: {body.velocity}");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            body.AddRelativeForce(new Vector2(-25, 0));
        }
    }
   void OnCollisionEnter2D(Collision2D col)
    {
    if (col.gameObject.tag == "EnemyOne")
    {
        this.transform.position = SpawnPoint;
    }
    }
}
  
