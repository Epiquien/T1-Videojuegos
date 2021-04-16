using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeController : MonoBehaviour
{
    private SpriteRenderer sr;
    private Animator _animator;
    private Rigidbody2D rb2d;

    public float UpSpeed = 80;
    public float Speed = 50;

    private bool PuedoSaltar = false;

   
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        SetIdleAnimation();

        if (Input.GetKey(KeyCode.RightArrow))
        {
            SetRunAnimation();
            rb2d.velocity = new Vector2(Speed, rb2d.velocity.y);
            sr.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity= Vector2.up * UpSpeed;
            PuedoSaltar = false;
        }
        
        
    }


    private void OnCollisionExit(Collision2D other)
    {
        if (other.collider)
        {
            SetDeadAnimation();
        }
    }


    private void SetRunAnimation()
    {
        _animator.SetInteger("Estado", 1);
    }

    private void SetIdleAnimation()
    {
        _animator.SetInteger("Estado", 0);
    }

    private void SetJumpAnimation()
    {
        _animator.SetInteger("Estado", 2);
    }
    
    private void SetDeadAnimation()
    {
        _animator.SetInteger("Estado", 3);
    }
}
