using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BirdMovement : MonoBehaviour {

    [SerializeField]
    private Transform target;
    private NavMeshAgent birdAgent;
    private Animator birdAnimator;
    [SerializeField]
    private RandomSoundPlayer birdFootsteps;

	// Use this for initialization
	void Start () {
        birdAgent = GetComponent<NavMeshAgent>();
        birdAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //set bird's destination:
        birdAgent.SetDestination(target.position);

        //measure the magnitude of the NavMeshAgent's velocity
        float speed = birdAgent.velocity.magnitude;

        //let the Animator know how fast it's going (so it can produce the correct animation)
        birdAnimator.SetFloat("Speed", speed);

        if (speed > 0f) birdFootsteps.enabled = true;
        else birdFootsteps.enabled = false;
	}
}
