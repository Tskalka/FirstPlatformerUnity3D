using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Basic movement script for the player
public class PlayerMovement : MonoBehaviour
{
    CharacterController playerController = new CharacterController();
    private float gravityPlayer = 20f;
    private float playerSpeed = 5.5f;
    private float jumpSpeed = 20f;
    private Vector3 moveDirection = Vector3.zero;
  
    // Start is called before the first frame update
    private void Start()
    {
        playerController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (playerController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= playerSpeed;
            if (Input.GetKeyDown("space"))
            {
                moveDirection.y += jumpSpeed;
            }
        }
 
        moveDirection.y -= gravityPlayer * Time.deltaTime;
        playerController.Move(moveDirection * Time.deltaTime);


    }
}
