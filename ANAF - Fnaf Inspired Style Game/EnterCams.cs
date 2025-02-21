using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterCams : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CamMenu;


    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.GameIsPaused == true)
        {
            CamMenu.SetActive(false);
        }
        if (PauseMenu.GameIsPaused == false)
        {
            CamMenu.SetActive(true);
        }
        if (CountDownTimer.GameEnd == true)
        {
            CamMenu.SetActive(false);
        }
        if (AIMovement.LostGame == true || FoxyAI.LostGame2 == true)
        {
            CamMenu.SetActive(false);
        }        
    }
}
