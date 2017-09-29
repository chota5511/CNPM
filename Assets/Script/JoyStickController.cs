using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class JoyStickController : MonoBehaviour {

    // Use this for initialization
    private Rigidbody2D rb2d;
    private Animator animator;
    public float Speed;
	void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
        FourWayController();
	}
    void FixedUpdate()
    {
        FourWayFixedUpdate();
    }
    void FourWayController()
    {

        //animator.SetFloat("Speed", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
        //animator.SetFloat("Speed", Mathf.Abs(Input.GetAxisRaw("Vertical")));
        float h = CrossPlatformInputManager.GetAxis("Horizontal");
        float v = CrossPlatformInputManager.GetAxis("Vertical");
        if (h == 0 && v == 0)
        {
            animator.SetBool("Walk", false);

        }
        if (h > 0 && h > Mathf.Abs(v))
        {
            animator.SetBool("Walk", true);
            animator.SetBool("Right", true);
            animator.SetBool("Left", false);
            animator.SetBool("Up", false);
            animator.SetBool("Down", false);
        }
        if (h < 0 && h < -Mathf.Abs(v))
        {
            animator.SetBool("Walk", true);
            animator.SetBool("Right", false);
            animator.SetBool("Left", true);
            animator.SetBool("Up", false);
            animator.SetBool("Down", false);
        }
        if (v > 0 && v > Mathf.Abs(h))
        {
            animator.SetBool("Walk", true);
            animator.SetBool("Right", false);
            animator.SetBool("Left", false);
            animator.SetBool("Up", true);
            animator.SetBool("Down", false);
        }
        if (v < 0 && v < -Mathf.Abs(h))
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
        float h = CrossPlatformInputManager.GetAxis("Horizontal") * Speed;
        float v = CrossPlatformInputManager.GetAxis("Vertical") * Speed;
        rb2d.velocity = new Vector2(h, v);
    }
}
