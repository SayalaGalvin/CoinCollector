using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    public GameObject lost;
    public GameObject win;
    public GameObject stopwin;
    public AudioSource gameover;
    public AudioSource stop;
	// Update is called once per frame
	void Update () {
        horizontalMove = Input.GetAxisRaw("Horizontal")* runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jumped");
            jump = true;

        }
	}
    void FixedUpdate()
    {
        //move
        controller.Move(horizontalMove * Time.fixedDeltaTime , false, jump);
        jump = false;
    }


    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Spike")
        {
            Destroy(gameObject);
            lost.SetActive(true);
            stopwin.SetActive(false);
            stop.Pause();
            gameover.Play();
        }
        if (col.gameObject.tag == "Platform")
        {
            Destroy(gameObject);
            lost.SetActive(true);
            stopwin.SetActive(false);
            stop.Pause();
            gameover.Play();
            
        }
    }
  
}
 


