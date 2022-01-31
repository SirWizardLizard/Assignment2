/*
 * Zechariah Burrus
 * Assignment 2
 * Lose condition for if the player flies out of bounds.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnBounds : MonoBehaviour {
    // Update is called once per frame
    void Update() {
        if(transform.position.y > 80 || transform.position.y < -51) {
            ScoreManager.gameOver = true;
        }
    }
}