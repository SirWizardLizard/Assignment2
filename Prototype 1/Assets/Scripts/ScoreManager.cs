/*
 * Zechariah Burrus
 * Assignment 2
 * Manages the player's score and allows them to restart.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {
    public static bool gameOver;
    public static bool won;
    public static int score;

    public Text textbox;

    //Initialize in start so they are reloaded along with the scene
    private void Start() {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update() {
        //If the game isn't over keep the score updated
        if(!gameOver) {
            textbox.text = "Score: " + score;
        }

        //If the score is greater than 3 then you've won
        if(score >= 3) {
            won = true;
            gameOver = true;
        }

        //Manage gameover conditions, win/lose and allow for restarting
        if (gameOver) {
            if(won) {
                textbox.text = "You win!\nPress R to Try Again!";
            } else {
                textbox.text = "You lose!\nPress R to Try Again!";
            }

            if(Input.GetKeyDown(KeyCode.R)) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
