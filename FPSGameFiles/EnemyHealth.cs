//Used the following source for assistance:
//https://youtu.be/anHxFtiVuiE 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    //The variable health is used to store an enemy's health
    public float health;

    //At the start of the game, the enemy's health is 5
    private void Start()
    {
        health = 5f;
    }

    //This function takes a numerical value that then gets subtracted from the enemy's health to update the new health of the enemy.
    //For example, if the enemy's health is 5 and they get damaged with a damageAmount of 1, then their updated health will be
    //5 - 1 = 4. As soon as the enemy's health reaches 0, the enemy will be killed.
    public void AddDamage(float damageAmount)
    {
        health -= damageAmount;

        if(health <= 0)
        {
            Destroy(gameObject);
            
        }
    }
}
