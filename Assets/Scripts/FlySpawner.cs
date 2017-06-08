using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySpawner : MonoBehaviour {

    [SerializeField]
    private GameObject flyPrefab;
    [SerializeField]
    private int minNumberOfFlies = 12;
    private float spawnRadius = 25f; //50x50 region, this is radius

    public static int totalFlies; //allows FlyPickup to adjust this without having a reference to it


	// Use this for initialization
	void Start () {
        totalFlies = 0;
	}
	
	// Update is called once per frame
	void Update () {
		while (totalFlies < minNumberOfFlies)
        {
            ++totalFlies;
            float positionX = Random.Range(-spawnRadius, spawnRadius);
            float positionZ = Random.Range(-spawnRadius, spawnRadius);
            Vector3 flyPosition = new Vector3(positionX,
                                              2f,
                                              positionZ);
            Instantiate(flyPrefab,
                        flyPosition,
                        Quaternion.identity);
        }
    }
}
