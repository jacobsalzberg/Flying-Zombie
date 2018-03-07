﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Player : MonoBehaviour {

    [SerializeField] private float jumpForce = 100f;
    [SerializeField] private AudioClip sfxJump;
    [SerializeField] private AudioClip sfxDeath;

    private Animator anim;
    private Rigidbody rigidBody;
    private bool jump = false;
    private AudioSource audioSource;

    void Awake()
    {
        Assert.IsNotNull(sfxJump);
        Assert.IsNotNull(sfxDeath);
    }

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
        {
            anim.Play("Jump");
            audioSource.PlayOneShot(sfxJump);
            rigidBody.useGravity = true;
            jump = true;
        }
	}

    void FixedUpdate () {
        if (jump == true)
        {
            jump = false;
            //reset velocity before each jump
            rigidBody.velocity = new Vector2(0, 0); 
            rigidBody.AddForce(new Vector2(0, jumpForce), ForceMode.Impulse);
        }
          
    }
}
