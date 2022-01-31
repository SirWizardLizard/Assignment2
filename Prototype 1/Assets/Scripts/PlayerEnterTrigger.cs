/*
 * Zechariah Burrus
 * Assignment 2
 * Changes text when the player enters a trigger zone
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Attach this to the player
public class PlayerEnterTrigger : MonoBehaviour {
    //Set reference in inspector
    public Text textbox;
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("TriggerZone")) {
            ScoreManager.score++;
        }
    }
}
