using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 0.5f; // ��ü�� �̵� �ӵ�

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, moveSpeed, 0);
        }
    }
}