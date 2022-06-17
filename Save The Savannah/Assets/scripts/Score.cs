using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public variables
    public Text scoreDisplay;
    public bool shouldReset = false;

    //private variables
    private static int scoreValue = 0;

    //Called by unity the frame after this object is created
    void start()
    {
        //check if we should be reseting the score this scene
        if(shouldReset = true)
        {
            //reset the score value back to 0
            scoreValue = 0;
        }
        //Update the display of the score based on the numerical value
        scoreDisplay.text = scoreValue.ToString();
    }

    //function to add to the player's score 
    public void AddScore(int toAdd)
    {
        // Update the numrical value of the score (Action 1)
        scoreValue = scoreValue + toAdd;

        // update the display of the score based on the number
        scoreDisplay.text = scoreValue.ToString();
    }
}
