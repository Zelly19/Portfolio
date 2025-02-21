using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AIMovement : MonoBehaviour
{
    public GameObject AIcharacter;
    float movement = 0f;
    bool enter = false;
    bool death = false; 
    float randomTime = 0f;
    bool AtDoorwayRight = false;
    public static bool LostGame = false;
    bool turn = false;

    // Start is called before the first frame update
    void Start()
    {
        AIcharacter.transform.position = new Vector3(-13f,.737f,-.39f);
        AIcharacter.transform.Rotate(0f, 0f, 0f);
        LostGame = false;
        turn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (enter == false)
        {
            StartCoroutine(your_timer());
        }
        if (death == true)
        {
            StartCoroutine(death_timer2());
        }
        if (AIcharacter.transform.position.z == -0.628f && turn == true)
        {
            AIcharacter.transform.Rotate(0f, -90f, 0f);
            turn = false;
        }
    }
    IEnumerator your_timer() 
    {
        if(death == false)
        {
            enter = true;
            randomTime = Random.Range(4f,21f);
            yield return new WaitForSeconds(6f);
            Move();
            enter = false;
        }
    }
    IEnumerator death_timer2() 
    {
        yield return new WaitForSeconds(5f);
        if (Door_Right.AIresetRight == true && AtDoorwayRight == true)
        {
            ResetPosition();
            enter = false;
        }
        else if (AtDoorwayRight == true && Door_Right.AIresetRight == false )
        {
            Jumpscare2();
        }
        
    }
    void Move()
    {
        movement += 1;
        if (movement <= 0)
        {
            AIcharacter.transform.position = new Vector3(-13f,.737f,-.39f);
            AIcharacter.transform.Rotate(0f, 0f, 0f);
        }
        if (movement == 1)
        {
            AIcharacter.transform.position = new Vector3(-2.595f, 0.309f, .81f);
            AIcharacter.transform.Rotate(0f, -90f, 0f);
        }
        else if (movement == 2)
        {
            AIcharacter.transform.position = new Vector3(-0.22f,.309f,9.632f);
            AIcharacter.transform.Rotate(0f, -90f, 0f);
        }
        else if (movement == 3)
        {
            AIcharacter.transform.position = new Vector3(-6.473f,.309f,9.863f);
            AIcharacter.transform.Rotate(0f, -40f, 0f);
        }
        else if (movement == 4)
        {
            AIcharacter.transform.position = new Vector3(4.665f,.309f,3.523f);
            AIcharacter.transform.Rotate(0f,-140f,0f);
        }
        else if (movement == 5)
        {
            AIcharacter.transform.position = new Vector3(16.148f,.31f,3.268f);
            AIcharacter.transform.Rotate(0f,45f,0f);
        }
        else if (movement == 6)
        {
            AIcharacter.transform.position = new Vector3(20.24f,.31f,2.959f);
            AIcharacter.transform.Rotate(0f,45f,0f);
            AtDoorwayRight = true;
            death = true;
            turn = true;
        }
    }
    void Jumpscare2()
    {
        if (AtDoorwayRight == true)
        {
            StartCoroutine(timer());
        }
    }

    IEnumerator timer() 
    {
        AIcharacter.transform.position = new Vector3(20.729f,-0.793f,-0.628f);
        yield return new WaitForSeconds(2f);
        LostGame = true;

    }
    void ResetPosition()
    {
        if (Door_Right.AIresetRight == true && AtDoorwayRight == true)
        {
            movement = -2;
            AIcharacter.transform.position = new Vector3(-13f,.737f,-.39f);
            AIcharacter.transform.Rotate(0f,-90f,0f);
            death = false;
            turn = false;
            AtDoorwayRight = false;
        }
        else
        {
            death_timer2();
        }
    }
}
