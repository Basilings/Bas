using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float jump_force;
    public float player_speed;
    private CharacterController _controller;

    // Use this for initialization
    void Start()
    {

        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void LateUpdate()
    {

        //Movement
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.SimpleMove(move * player_speed);

        //Jump
        if (Input.GetButtonDown("Jump"))
        {
            if (_controller.isGrounded)
            {
                move.y = jump_force;
            }

            //Changing color

            if (Input.GetKeyDown(KeyCode.R))
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;

            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;

            }

        }
    }
}
