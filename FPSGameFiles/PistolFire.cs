//Used the following sources for assistance:
//https://youtu.be/CqqQ34p0lvE
//https://youtu.be/DEtZUeVY9qk 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PistolFire : MonoBehaviour
{
   //represents our gun in the game
   public GameObject blackPistol;
   
   //since the gun is not firing initially, isFiring gets set to false
   public bool isFiring = false;
   
   //the raycasts of the gun
   public GameObject muzzleFlash;
   
   //the sound the gun makes as it shoots
   public AudioSource pistolShot;
   
   //representative of the distance the gun is away from the target
   public float toTarget;
   
   //the projectile the gun shoots
   public GameObject projectile;
   
   //the camera that follows the player of the game; the player always holds a gun
   public Camera fps;




   //This method is what allows the gun to shoot. As the player presses down the right key button of the mouse (known as Fire1),
   //the gun will start firing raycasts using the StartCoroutine method. Additionally, since this gun also shoots projectiles,
   //the position of the projectile will be transformed to the appropriate coordinates of where it is supposed to land when
   //the gun shoots.
   void Update()
   {
       if(Input.GetButtonDown("Fire1"))
       {
        if(isFiring == false)
        {
            StartCoroutine(FireThePistol());
            projectile.transform.position = transform.position + fps.transform.forward * 2;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = fps.transform.forward * 40;


        }
       }

   }

   //This method updates the variables declared above accordingly when the gun shoots. Since the gun is shooting at this time,
   //isFiring gets set to true. Additionally, another important thing to note is that the animation of the gun gets called. As shown in
   //the game, when the gun shoots, it slightly bobs up and down, which is part of the animation. Meanwhile, toTarget gets updated to be
   //the new distance between the current target of the gun and the player's position. Since the gun shoots raycasts alongside
   //projectiles, muzzleFlash becomes active until the all the necessary raycasts get shot.
   IEnumerator FireThePistol()
   {
    isFiring = true;
    toTarget = PlayerCasting.distanceFromTarget;
    blackPistol.GetComponent<Animator>().Play("FirePistol");
    pistolShot.Play();
    muzzleFlash.SetActive(true);
    yield return new WaitForSeconds(0.05f);
    muzzleFlash.SetActive(false);
    yield return new WaitForSeconds(0.25f);
    blackPistol.GetComponent<Animator>().Play("New State");
    isFiring = false;
   }

   
   



}
