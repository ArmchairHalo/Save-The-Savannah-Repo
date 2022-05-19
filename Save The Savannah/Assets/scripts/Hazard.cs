    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Purpose: Whenever our player touches the object this hazard script is attached to,
//delete the player
public class Hazard : MonoBehaviour
{

    public int hazardDamage = 10;

    //CONDITION: when the player touches this object...
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth healthScript = collision.gameObject.GetComponent<PlayerHealth>();
         // null if health script is not present

        //if the thing we touched is the player...
        if (healthScript != null)
        {
            // kill the player
            //healthScript.kill();

            //damage the player
            healthScript.ChangeHealth(-hazardDamage);
        }
    }
}
