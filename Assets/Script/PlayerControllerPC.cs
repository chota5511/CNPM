using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerPC : MonoBehaviour {

    public float Speed;
    public float maxspeed = 1f;
    private Rigidbody2D rb2d;
    private Animator animator;
	// Use this for initialization
	void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
	}
    void Update()
    {
        //TwoWayController();
        FourWayController();
        // Update is called once per frame
    }
    void FixedUpdate()
    {
        FourWayFixedUpdate();
        //TwoWayFixedUpdate();
    }

    //Be ware when using my Script
    void TwoWayController()
    {
        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            animator.SetBool("Walk", true);
        }
        else
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
                animator.SetBool("Walk", true);
            }
            else
            {
                if (Input.GetAxisRaw("Horizontal") == 0)
                {
                    animator.SetBool("Walk", false);
                }
            }
        }
    }
    void TwoWayFixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rb2d.AddForce(Vector2.right * Speed * h);
        if (rb2d.velocity.x > maxspeed)
        {
            rb2d.velocity = new Vector2(maxspeed, rb2d.velocity.y);
        }
        if (rb2d.velocity.x < -maxspeed)
        {
            rb2d.velocity = new Vector2(-maxspeed, rb2d.velocity.y);
        }
    }


void FourWayController()
    {

            //animator.SetFloat("Speed", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
            //animator.SetFloat("Speed", Mathf.Abs(Input.GetAxisRaw("Vertical")));
            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");
            if (h == 0 && v == 0)
            {
                animator.SetBool("Walk", false);

            }
            if (h > 0)
            {
                animator.SetBool("Walk", true);
                animator.SetBool("Right", true);
                animator.SetBool("Left", false);
                animator.SetBool("Up", false);
                animator.SetBool("Down", false);
            }
            if (h < 0)
            {
                animator.SetBool("Walk", true);
                animator.SetBool("Right", false);
                animator.SetBool("Left", true);
                animator.SetBool("Up", false);
                animator.SetBool("Down", false);
            }
            if (v > 0)
            {
                animator.SetBool("Walk", true);
                animator.SetBool("Right", false);
                animator.SetBool("Left", false);
                animator.SetBool("Up", true);
                animator.SetBool("Down", false);
            }
            if (v < 0)
            {
                animator.SetBool("Walk", true);
                animator.SetBool("Right", false);
                animator.SetBool("Left", false);
                animator.SetBool("Up", false);
                animator.SetBool("Down", true);
            }
     }

    void FourWayFixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal") * Speed;
        float v = Input.GetAxisRaw("Vertical") * Speed;

        rb2d.velocity = new Vector2(h, v);
    }
}

