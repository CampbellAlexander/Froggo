using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupParticlesDestruction : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 5f); //destroy the parent GameObject after 5s
	}
}
