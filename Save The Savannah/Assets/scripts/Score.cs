using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public variables
    public Text scoreDisplay;
    
    //private variables
    private int scoreValue = 0;

    //function to add to the player's score 
    public void AddScore(int toAdd)
    {
        // Update the numrical value of the score (Action 1)
        scoreValue = scoreValue + toAdd;

        // update the display of the score based on the number
        scoreDisplay.text = scoreValue.ToString();
    }
}
