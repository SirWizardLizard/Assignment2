/*
 * Zechariah Burrus
 * Assignment 2
 * Player loses if they fall below a specific y level
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Attach to player
public class LoseOnFall : MonoBehaviour {
    // Update is called once per frame
    void Update() {
        if(transform.position.y < -1){
            ScoreManager.gameOver = true;
        }   
    }
}
