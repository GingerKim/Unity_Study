using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 inputVec;
    Rigidbody2D rd2d;
    public float speed;

    void Awake()
    {
        rd2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 moveVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        rd2d.MovePosition(rd2d.position + moveVec);
      
    }
}
