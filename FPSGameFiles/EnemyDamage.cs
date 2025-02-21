//Used the following sources for assistance:
//https://youtu.be/2CfCJesweLc
//https://forum.unity.com/threads/how-do-you-make-an-enemy-deal-damage-to-a-player-on-collision.892846/#:~:text=For%20two%20objects%20to%20collide%2C%20both%20need%20a,a%20standard%20Monobehavior%20method%2C%20called%20OnCollisionEnter%20%28%29.%20https%3A%2F%2Fdocs.unity3d.com%2FScriptReference%2FCollider.OnCollisionEnter.html
//https://youtu.be/QRp4V1JTZnM
//https://youtu.be/ZoZcBgRR9ns
//https://youtu.be/Bc9lmHjqLZc 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//In order to damage an enemy, the colliders of the enemy and the gun's projectile must touch each other. A collider is simply
//a surface covered on the outside of an object that has the object react in some way when it is in contact with another object.
//In this case, if the object that represents an enemy comes in contact with (gets hit by) a projectile, it will be damaged.
public class EnemyDamage : MonoBehaviour
{

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "EnemyTarget")
        {
            //An enemy gets damaged by having their health removed. In order for their health to be removed, the EnemyHealth class
            //gets referenced; the function AddDamage from the EnemyHealth class gets called, with 1f being the amount that damages the
            //enemy's health.
            col.gameObject.GetComponent<EnemyHealth>().AddDamage(1f);
        }
    }
}
