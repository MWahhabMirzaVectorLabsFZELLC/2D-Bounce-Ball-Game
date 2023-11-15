using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    Rigidbody2D rb;
    public float moveSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        KeyMove();
    }

    private void KeyMove()
    {
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.velocity = Vector2.right * moveSpeed;
            }

            // No Movement
            else
            {
                rb.velocity = Vector2.zero;
            }

            // Move Left
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.velocity = Vector2.left * moveSpeed;
            }
        }
    }
}
