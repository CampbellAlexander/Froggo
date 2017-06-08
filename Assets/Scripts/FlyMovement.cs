using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMovement : MonoBehaviour {

    [SerializeField]
    private Transform center;
    private Light glow;

    private float flySpeed;

	// Use this for initialization
	void Start () {
        glow = GetComponent<Light>();
        flySpeed = Random.Range(300f, 700f); //we want each fly to fly around at a random speed
    }
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(center.position, //the transform location of the fly
                               Vector3.up,      //(0,1,0), fly around the Y-axis
                               flySpeed * Time.deltaTime);

        glow.transform.RotateAround(center.position, //the transform location of the fly
                                     Vector3.up,      //(0,1,0), fly around the Y-axis
                                     flySpeed * Time.deltaTime);

    }
}
