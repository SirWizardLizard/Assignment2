/*
 * Zechariah Burrus
 * Assignment 2
 * Increment score the first time a player enters a trigger zone
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this script to a trigger zone
public class TriggerZoneAddScoreOnce : MonoBehaviour {
    private bool triggered = false;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player") && !triggered) {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
