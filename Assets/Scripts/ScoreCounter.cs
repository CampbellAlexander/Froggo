using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //this includes the Text class

public class ScoreCounter : MonoBehaviour {

    public static int score;
    private Text scoreCounterText;

	// Use this for initialization
	void Start () {
        score = 0;
        scoreCounterText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        //update the text property of the Text
        scoreCounterText.text = score + " flies";
	}
}
