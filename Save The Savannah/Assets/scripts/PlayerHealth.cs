using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100; //editable in unity
    private int currentHealth = 0;

    // Awake happens when the object is first created
    // It happens before all scripts are set up
    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void kill()
    {
        //Destroy(gameObject);

        //alternative:Load a game over screen
        //SceneManager.LoadScene("Game Over");

        //alternative: Reload the current scene
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }

    //change our current health by the given amount
    public void ChangeHealth(int changeAmount)
    {
        // take our current health, add the change amount, and store the result
        //back into our current health value
        currentHealth = currentHealth + changeAmount;

        // Did this make our health 0 or negative?
        // If so, we should die
        if (currentHealth <= 0)
        {
            kill();
        }
    }

    //getter function to give information to the calling code
    //the int means that an interger (whole number) will be given back
    //the return is what will be given back
    public int GetHealth()
    {
        return currentHealth;
    }
}
