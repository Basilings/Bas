using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public int player_speed;
    private CharacterController _controller;

	// Use this for initialization
	void Start () {

        _controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.SimpleMove(move * player_speed);




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
