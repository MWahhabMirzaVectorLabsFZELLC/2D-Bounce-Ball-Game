using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float bounceForce;

    bool gameStarted;

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
        if (!gameStarted)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartBounce();
                gameStarted = true;
                GameManager.Instance.GameStart();
            }
        }
    }

    void StartBounce()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-1, 1), 1);

        rb.AddForce(randomDirection * bounceForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fall Check")
        {
            GameManager.Instance.Restart();
        }

        else if (collision.gameObject.tag == "Paddle")
        {
            GameManager.Instance.ScoreUp();
        }
    }
}
