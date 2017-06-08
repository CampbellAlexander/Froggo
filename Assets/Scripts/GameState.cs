using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameState : MonoBehaviour {

    private bool gameStarted = false;
    private float restartDelay = 3f;
    private float restartTimer;
    private PlayerMovement playerMovement;
    private PlayerHealth playerHealth;

    [SerializeField]
    private Text gameStateText;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private BirdMovement birdMovement;
    [SerializeField]
    private FollowCamera followCamera;
    

	// Use this for initialization
	void Start () {
        Cursor.visible = false;

        playerMovement = player.GetComponent<PlayerMovement>();
        playerHealth = player.GetComponent<PlayerHealth>();

        // Prevent movement at start of game:
        playerMovement.enabled = false;
        birdMovement.enabled = false;
        // Prevent follow camera from moving to game position:
        followCamera.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameStarted &&
            Input.GetKeyUp(KeyCode.Space))
        {
            StartGame();
        }

        if (!playerHealth.alive)
        {
            EndGame();

            // increment timer to count up to restarting
            restartTimer += Time.deltaTime; //timer counts upwards every frame
            if (restartTimer >= restartDelay)
            {
                // reload the level:
                //Application.LoadLevel(Application.loadedLevel); // deprecated
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
	}

    private void StartGame()
    {
        gameStarted = true;
        gameStateText.color = Color.clear; //remove visibility of start text
        playerMovement.enabled = true;
        birdMovement.enabled = true;
        followCamera.enabled = true;
    }

    private void EndGame()
    {
        gameStarted = false;
        //show game over text:
        gameStateText.text = "Game Over!";
        gameStateText.color = Color.white;

        //remove player from game
        player.SetActive(false);
    }
}
