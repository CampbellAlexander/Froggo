using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    // SerializeField allows the field to be set-able within Unity.
    // you only neeed to drag and drop the GameObject itself to it and it will 
    // grab the appropriate component (in this case, the Tranform)
    [SerializeField]
    private Transform playerTransform;
    [SerializeField]
    private Vector3 offset;

    private float cameraFollowSpeed = 5f;


	
	// Update is called once per frame
	void Update () {
        Vector3 newPosition = playerTransform.position + offset; // add 2 vectors together
        transform.position = Vector3.Lerp(transform.position,
                                          newPosition,
                                          cameraFollowSpeed * Time.deltaTime);
	}
}
