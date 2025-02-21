//Used the following source for assistance:
//https://youtu.be/gcdPOR5WAu8 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    
    
    //both variables are representative of distance the player is from the target (a.k.a the gun's aim)
    public static float distanceFromTarget;
    public float toTarget;


    //As soon as the gun shoots (specifically raycasts in this context), the position of the raycasts will be changed where appropiately
    //depending on where the gun aims
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            toTarget = hit.distance;
            distanceFromTarget = hit.distance;
        }

        
    }
}
