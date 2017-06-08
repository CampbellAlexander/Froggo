using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public bool alive;

    [SerializeField]
    private GameObject pickupPrefab;

	// Use this for initialization
	void Start () {
        alive = true;
	}

    void OnTriggerEnter(Collider other)
    {
        //physics engine is NOT precise
        //chance that it detects multiple collisions
        if (other.CompareTag("Enemy") &&
            alive)
        {
            alive = false;

            //create pickup particles
            Instantiate(pickupPrefab,        //prefab
                        transform.position,  //location
                        Quaternion.identity);//rotation
        }
    }
}
