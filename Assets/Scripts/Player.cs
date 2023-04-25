using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    public float gravity = -9.8f;
    public float height = 3f;

    public Rigidbody2D rb;
    public Animator anim;

    public GameManager gameManager;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * height;
            rb.velocity = Vector3.zero;
            anim.Play("Bird_Touch");
        }
/*
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameManager.Pause();
        }*/

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * height;
            }
        }

        if (rb.velocity.y < -1f)
        {
            anim.Play("Bird_Drop");
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<GameManager>().GameOver();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Scoring"))
        {
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }


}
