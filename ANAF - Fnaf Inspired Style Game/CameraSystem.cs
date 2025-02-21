using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    public Camera cam1a;
    public Camera cam1b;
    public Camera cam1c;
    public Camera cam2a;
    public Camera cam2b;
    public Camera cam3;
    public Camera cam4a;
    public Camera cam4b;
    public Camera cam5;
    public Camera cam6;
    public Camera cam7;
    public Camera camsec;
    public GameObject camSystem;
    public bool CamSystemActive;
    public AudioSource cameranoise;
    public AudioSource cameranoiseEnd;

    // Start is called before the first frame update
    void Start()
    {
        camSystem.SetActive(false);
                
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            CamSystemActive = !CamSystemActive;
            if (CamSystemActive)
            {
                ActivateCamSystem();

            }
            if (!CamSystemActive)
            {
                DeactivateCamSystem();
            }
        }
    }
    void ActivateCamSystem()
    {
        camSystem.SetActive(true);
        cameranoise.Play();
        
    }
    public void DeactivateCamSystem()
    {
        camSystem.SetActive(false);
        camsec.enabled = true;
        cameranoiseEnd.Play();
        cam1a.GetComponent<AudioListener> ().enabled = false;
        cam1b.GetComponent<AudioListener> ().enabled = false;
        cam1c.GetComponent<AudioListener> ().enabled = false;
        cam2a.GetComponent<AudioListener> ().enabled = false;
        cam2b.GetComponent<AudioListener> ().enabled = false;
        cam3.GetComponent<AudioListener> ().enabled = false;
        cam4a.GetComponent<AudioListener> ().enabled = false;
        cam4b.GetComponent<AudioListener> ().enabled = false;
        cam5.GetComponent<AudioListener> ().enabled = false;
        cam6.GetComponent<AudioListener> ().enabled = false;
        cam7.GetComponent<AudioListener> ().enabled = false;
        camsec.GetComponent<AudioListener> ().enabled = true;
        camsec.enabled = true;
        cam1a.enabled = false;
        cam1b.enabled = false;
        cam1c.enabled = false;
        cam2a.enabled = false;
        cam2b.enabled = false;
        cam3.enabled = false;
        cam4a.enabled = false;
        cam4b.enabled = false;
        cam5.enabled = false;
        cam6.enabled = false;
        cam7.enabled = false;
        cameranoise.Stop();
    }
    public void PullUPCams()
    {
        ActivateCamSystem();
    }
    public void SettoCamera1A()
    {
        cameranoiseEnd.Play();
        cam1a.GetComponent<AudioListener> ().enabled = true;
        cam1b.GetComponent<AudioListener> ().enabled = false;
        cam1c.GetComponent<AudioListener> ().enabled = false;
        cam2a.GetComponent<AudioListener> ().enabled = false;
        cam2b.GetComponent<AudioListener> ().enabled = false;
        cam3.GetComponent<AudioListener> ().enabled = false;
        cam4a.GetComponent<AudioListener> ().enabled = false;
        cam4b.GetComponent<AudioListener> ().enabled = false;
        cam5.GetComponent<AudioListener> ().enabled = false;
        cam6.GetComponent<AudioListener> ().enabled = false;
        cam7.GetComponent<AudioListener> ().enabled = false;
        camsec.GetComponent<AudioListener> ().enabled = false;
        camsec.enabled = false;
        cam1a.enabled = true;
        cam1b.enabled = false;
        cam1c.enabled = false;
        cam2a.enabled = false;
        cam2b.enabled = false;
        cam3.enabled = false;
        cam4a.enabled = false;
        cam4b.enabled = false;
        cam5.enabled = false;
        cam6.enabled = false;
        cam7.enabled = false;
    }
    public void SettoCamera1B()
    {
        cameranoiseEnd.Play();
        cam1a.GetComponent<AudioListener> ().enabled = false;
        cam1b.GetComponent<AudioListener> ().enabled = true;
        cam1c.GetComponent<AudioListener> ().enabled = false;
        cam2a.GetComponent<AudioListener> ().enabled = false;
        cam2b.GetComponent<AudioListener> ().enabled = false;
        cam3.GetComponent<AudioListener> ().enabled = false;
        cam4a.GetComponent<AudioListener> ().enabled = false;
        cam4b.GetComponent<AudioListener> ().enabled = false;
        cam5.GetComponent<AudioListener> ().enabled = false;
        cam6.GetComponent<AudioListener> ().enabled = false;
        cam7.GetComponent<AudioListener> ().enabled = false;
        camsec.GetComponent<AudioListener> ().enabled = false;
        camsec.enabled = false;
        cam1a.enabled = false;
        cam1b.enabled = true;
        cam1c.enabled = false;
        cam2a.enabled = false;
        cam2b.enabled = false;
        cam3.enabled = false;
        cam4a.enabled = false;
        cam4b.enabled = false;
        cam5.enabled = false;
        cam6.enabled = false;
        cam7.enabled = false;
    }
    public void SettoCamera1C()
    {
        cameranoiseEnd.Play();
        cam1a.GetComponent<AudioListener> ().enabled = false;
        cam1b.GetComponent<AudioListener> ().enabled = false;
        cam1c.GetComponent<AudioListener> ().enabled = true;
        cam2a.GetComponent<AudioListener> ().enabled = false;
        cam2b.GetComponent<AudioListener> ().enabled = false;
        cam3.GetComponent<AudioListener> ().enabled = false;
        cam4a.GetComponent<AudioListener> ().enabled = false;
        cam4b.GetComponent<AudioListener> ().enabled = false;
        cam5.GetComponent<AudioListener> ().enabled = false;
        cam6.GetComponent<AudioListener> ().enabled = false;
        cam7.GetComponent<AudioListener> ().enabled = false;
        camsec.GetComponent<AudioListener> ().enabled = false;
        camsec.enabled = false;
        cam1a.enabled = false;
        cam1b.enabled = false;
        cam1c.enabled = true;
        cam2a.enabled = false;
        cam2b.enabled = false;
        cam3.enabled = false;
        cam4a.enabled = false;
        cam4b.enabled = false;
        cam5.enabled = false;
        cam6.enabled = false;
        cam7.enabled = false;
    }
    public void SettoCamera2A()
    {
        cameranoiseEnd.Play();
        cam1a.GetComponent<AudioListener> ().enabled = false;
        cam1b.GetComponent<AudioListener> ().enabled = false;
        cam1c.GetComponent<AudioListener> ().enabled = false;
        cam2a.GetComponent<AudioListener> ().enabled = true;
        cam2b.GetComponent<AudioListener> ().enabled = false;
        cam3.GetComponent<AudioListener> ().enabled = false;
        cam4a.GetComponent<AudioListener> ().enabled = false;
        cam4b.GetComponent<AudioListener> ().enabled = false;
        cam5.GetComponent<AudioListener> ().enabled = false;
        cam6.GetComponent<AudioListener> ().enabled = false;
        cam7.GetComponent<AudioListener> ().enabled = false;
        camsec.GetComponent<AudioListener> ().enabled = false;
        camsec.enabled = false;
        cam1a.enabled = false;
        cam1b.enabled = false;
        cam1c.enabled = false;
        cam2a.enabled = true;
        cam2b.enabled = false;
        cam3.enabled = false;
        cam4a.enabled = false;
        cam4b.enabled = false;
        cam5.enabled = false;
        cam6.enabled = false;
        cam7.enabled = false;
    }
    public void SettoCamera2B()
    {
        cameranoiseEnd.Play();
        cam1a.GetComponent<AudioListener> ().enabled = false;
        cam1b.GetComponent<AudioListener> ().enabled = false;
        cam1c.GetComponent<AudioListener> ().enabled = false;
        cam2a.GetComponent<AudioListener> ().enabled = false;
        cam2b.GetComponent<AudioListener> ().enabled = true;
        cam3.GetComponent<AudioListener> ().enabled = false;
        cam4a.GetComponent<AudioListener> ().enabled = false;
        cam4b.GetComponent<AudioListener> ().enabled = false;
        cam5.GetComponent<AudioListener> ().enabled = false;
        cam6.GetComponent<AudioListener> ().enabled = false;
        cam7.GetComponent<AudioListener> ().enabled = false;
        camsec.GetComponent<AudioListener> ().enabled = false;
        camsec.enabled = false;
        cam1a.enabled = false;
        cam1b.enabled = false;
        cam1c.enabled = false;
        cam2a.enabled = false;
        cam2b.enabled = true;
        cam3.enabled = false;
        cam4a.enabled = false;
        cam4b.enabled = false;
        cam5.enabled = false;
        cam6.enabled = false;
        cam7.enabled = false;
    }
    public void SettoCamera3()
    {
        cameranoiseEnd.Play();
        cam1a.GetComponent<AudioListener> ().enabled = false;
        cam1b.GetComponent<AudioListener> ().enabled = false;
        cam1c.GetComponent<AudioListener> ().enabled = false;
        cam2a.GetComponent<AudioListener> ().enabled = false;
        cam2b.GetComponent<AudioListener> ().enabled = false;
        cam3.GetComponent<AudioListener> ().enabled = true;
        cam4a.GetComponent<AudioListener> ().enabled = false;
        cam4b.GetComponent<AudioListener> ().enabled = false;
        cam5.GetComponent<AudioListener> ().enabled = false;
        cam6.GetComponent<AudioListener> ().enabled = false;
        cam7.GetComponent<AudioListener> ().enabled = false;
        camsec.GetComponent<AudioListener> ().enabled = false;
        camsec.enabled = false;
        cam1a.enabled = false;
        cam1b.enabled = false;
        cam1c.enabled = false;
        cam2a.enabled = false;
        cam2b.enabled = false;
        cam3.enabled = true;
        cam4a.enabled = false;
        cam4b.enabled = false;
        cam5.enabled = false;
        cam6.enabled = false;
        cam7.enabled = false;
    }
    public void SettoCamera4A()
    {
        cameranoiseEnd.Play();
        cam1a.GetComponent<AudioListener> ().enabled = false;
        cam1b.GetComponent<AudioListener> ().enabled = false;
        cam1c.GetComponent<AudioListener> ().enabled = false;
        cam2a.GetComponent<AudioListener> ().enabled = false;
        cam2b.GetComponent<AudioListener> ().enabled = false;
        cam3.GetComponent<AudioListener> ().enabled = false;
        cam4a.GetComponent<AudioListener> ().enabled = true;
        cam4b.GetComponent<AudioListener> ().enabled = false;
        cam5.GetComponent<AudioListener> ().enabled = false;
        cam6.GetComponent<AudioListener> ().enabled = false;
        cam7.GetComponent<AudioListener> ().enabled = false;
        camsec.GetComponent<AudioListener> ().enabled = false;
        camsec.enabled = false;
        cam1a.enabled = false;
        cam1b.enabled = false;
        cam1c.enabled = false;
        cam2a.enabled = false;
        cam2b.enabled = false;
        cam3.enabled = false;
        cam4a.enabled = true;
        cam4b.enabled = false;
        cam5.enabled = false;
        cam6.enabled = false;
        cam7.enabled = false;
    }
    public void SettoCamera4B()
    {
        cameranoiseEnd.Play();
        cam1a.GetComponent<AudioListener> ().enabled = false;
        cam1b.GetComponent<AudioListener> ().enabled = false;
        cam1c.GetComponent<AudioListener> ().enabled = false;
        cam2a.GetComponent<AudioListener> ().enabled = false;
        cam2b.GetComponent<AudioListener> ().enabled = false;
        cam3.GetComponent<AudioListener> ().enabled = false;
        cam4a.GetComponent<AudioListener> ().enabled = false;
        cam4b.GetComponent<AudioListener> ().enabled = true;
        cam5.GetComponent<AudioListener> ().enabled = false;
        cam6.GetComponent<AudioListener> ().enabled = false;
        cam7.GetComponent<AudioListener> ().enabled = false;
        camsec.GetComponent<AudioListener> ().enabled = false;
        camsec.enabled = false;
        cam1a.enabled = false;
        cam1b.enabled = false;
        cam1c.enabled = false;
        cam2a.enabled = false;
        cam2b.enabled = false;
        cam3.enabled = false;
        cam4a.enabled = false;
        cam4b.enabled = true;
        cam5.enabled = false;
        cam6.enabled = false;
        cam7.enabled = false;
    }
    public void SettoCamera5()
    {
        cameranoiseEnd.Play();
        cam1a.GetComponent<AudioListener> ().enabled = false;
        cam1b.GetComponent<AudioListener> ().enabled = false;
        cam1c.GetComponent<AudioListener> ().enabled = false;
        cam2a.GetComponent<AudioListener> ().enabled = false;
        cam2b.GetComponent<AudioListener> ().enabled = false;
        cam3.GetComponent<AudioListener> ().enabled = false;
        cam4a.GetComponent<AudioListener> ().enabled = false;
        cam4b.GetComponent<AudioListener> ().enabled = false;
        cam5.GetComponent<AudioListener> ().enabled = true;
        cam6.GetComponent<AudioListener> ().enabled = false;
        cam7.GetComponent<AudioListener> ().enabled = false;
        camsec.GetComponent<AudioListener> ().enabled = false;
        camsec.enabled = false;
        cam1a.enabled = false;
        cam1b.enabled = false;
        cam1c.enabled = false;
        cam2a.enabled = false;
        cam2b.enabled = false;
        cam3.enabled = false;
        cam4a.enabled = false;
        cam4b.enabled = false;
        cam5.enabled = true;
        cam6.enabled = false;
        cam7.enabled = false;
    }
    public void SettoCamera6()
    {
        cameranoiseEnd.Play();
        cam1a.GetComponent<AudioListener> ().enabled = false;
        cam1b.GetComponent<AudioListener> ().enabled = false;
        cam1c.GetComponent<AudioListener> ().enabled = false;
        cam2a.GetComponent<AudioListener> ().enabled = false;
        cam2b.GetComponent<AudioListener> ().enabled = false;
        cam3.GetComponent<AudioListener> ().enabled = false;
        cam4a.GetComponent<AudioListener> ().enabled = false;
        cam4b.GetComponent<AudioListener> ().enabled = false;
        cam5.GetComponent<AudioListener> ().enabled = false;
        cam6.GetComponent<AudioListener> ().enabled = true;
        cam7.GetComponent<AudioListener> ().enabled = false;
        camsec.GetComponent<AudioListener> ().enabled = false;
        camsec.enabled = false;
        cam1a.enabled = false;
        cam1b.enabled = false;
        cam1c.enabled = false;
        cam2a.enabled = false;
        cam2b.enabled = false;
        cam3.enabled = false;
        cam4a.enabled = false;
        cam4b.enabled = false;
        cam5.enabled = false;
        cam6.enabled = true;
        cam7.enabled = false;
    }
    public void SettoCamera7()
    {
        cameranoiseEnd.Play();
        cam1a.GetComponent<AudioListener> ().enabled = false;
        cam1b.GetComponent<AudioListener> ().enabled = false;
        cam1c.GetComponent<AudioListener> ().enabled = false;
        cam2a.GetComponent<AudioListener> ().enabled = false;
        cam2b.GetComponent<AudioListener> ().enabled = false;
        cam3.GetComponent<AudioListener> ().enabled = false;
        cam4a.GetComponent<AudioListener> ().enabled = false;
        cam4b.GetComponent<AudioListener> ().enabled = false;
        cam5.GetComponent<AudioListener> ().enabled = false;
        cam6.GetComponent<AudioListener> ().enabled = false;
        cam7.GetComponent<AudioListener> ().enabled = true;
        camsec.GetComponent<AudioListener> ().enabled = false;
        camsec.enabled = false;
        cam1a.enabled = false;
        cam1b.enabled = false;
        cam1c.enabled = false;
        cam2a.enabled = false;
        cam2b.enabled = false;
        cam3.enabled = false;
        cam4a.enabled = false;
        cam4b.enabled = false;
        cam5.enabled = false;
        cam6.enabled = false;
        cam7.enabled = true;
    }
}
