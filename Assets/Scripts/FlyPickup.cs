using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPickup : MonoBehaviour {

    [SerializeField]
    private GameObject pickupPrefab;

    void OnTriggerEnter(Collider other)
    {
        // if the Collider other is tagged with "Player"
        if (other.CompareTag("Player"))
        {
            Instantiate(pickupPrefab,        // object we wish to instantiate
                        transform.position,  // Vector3 specifying location of instantiation
                        Quaternion.identity);// Identity is No-rotation (rotation is not needed)
            Destroy(gameObject); //gameObject means to "this"
            FlySpawner.totalFlies--;
            if (++ScoreCounter.score > HighScore.highScore) HighScore.highScore = ScoreCounter.score; 
        }
    }
	
}
