using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Animator playerAnimator;
    private float moveHorizontal;
    private float moveVertical;
    private Vector3 movement;
    private float turningSpeed = 25f;
    private Rigidbody playerRigidbody;
    [SerializeField]
    private RandomSoundPlayer playerFootsteps;
    
	

	void Start() // Use this for initialization
    {  
        // grab the Animator & Rigidbody game components of the Player GameObject
        playerAnimator = GetComponent<Animator>(); 
        playerRigidbody = GetComponent<Rigidbody>();
	}
	


	
	void Update() // Called once per frame
    {
        //gather input from keyboard:
        moveHorizontal = Input.GetAxisRaw("Horizontal"); //"Horizontal" is mapped to left/right arrows and a/d keys for horizontal movement
        moveVertical = Input.GetAxisRaw("Vertical");     //"Vertical" is mapped to up/down arrows and w/s keys for vertical movement
        //update movement based on input:
        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
	}



    void FixedUpdate() //smooth animation for objects based on physics, doesn't run as often as Update() (for performance)
    {
        //if the player's movement vector is not equal to 0
        if (movement != Vector3.zero)
        {
            // 1) create a target rotation based on movement vector
            Quaternion targetRotation = Quaternion.LookRotation(movement, Vector3.up);
            // 2) create another rotation that moves from the current rotation to the target rotation via Linear Interpolation
            Quaternion newRotation = Quaternion.Lerp(playerRigidbody.rotation,       //starting rotation
                                                     targetRotation,                 //ending rotation
                                                     turningSpeed * Time.deltaTime); //amount of time rotation should last **THIS LINE IS IMPORTANT TO NOTE**
            // 3) apply the rotation to the Player's Rigidbody
            playerRigidbody.MoveRotation(newRotation);
            // 4) finally, move forward
            playerAnimator.SetFloat("Speed", 3f); //set the Speed value to 3

            //5) and dont forget to play footstep sounds!
            playerFootsteps.enabled = true;
        }
        else
        {
            playerAnimator.SetFloat("Speed", 0.0f); //make sure the frog doesn't move if not pressing a movement key
            playerFootsteps.enabled = false;
        }
    }
}
