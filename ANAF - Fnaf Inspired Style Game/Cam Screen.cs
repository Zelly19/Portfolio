using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScreen : MonoBehaviour
{
    public Camera camerasecurityroom;
    public Camera camera1a;
    public Camera camera1b;
    public Camera camera1c;
    public Camera camera2a;
    public Camera camera2b;
    public Camera camera3;
    public Camera camera4a;
    public Camera camera4b;
    public Camera camera5;
    public Camera camera6;
    public Camera camera7;
    public Camera SystemCams;
    // Start is called before the first frame update
    void Start()
    {
        camerasecurityroom.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void CamSys()
    {
        camera1a.enabled = false;
        camera1b.enabled = false;
        camera1c.enabled = false;
        camera2a.enabled = false;
        camera2b.enabled = false;
        camera3.enabled = false;
        camera4a.enabled = false;
        camera4b.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;

    }
    void Cam1A()
    {
        camera1a.enabled = true;
        camera1b.enabled = false;
        camera1c.enabled = false;
        camera2a.enabled = false;
        camera2b.enabled = false;
        camera3.enabled = false;
        camera4a.enabled = false;
        camera4b.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;

    }
        void Cam1B()
    {
        camera1a.enabled = false;
        camera1b.enabled = true;
        camera1c.enabled = false;
        camera2a.enabled = false;
        camera2b.enabled = false;
        camera3.enabled = false;
        camera4a.enabled = false;
        camera4b.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;

    }
        void Cam1C()
    {
        camera1a.enabled = false;
        camera1b.enabled = false;
        camera1c.enabled = true;
        camera2a.enabled = false;
        camera2b.enabled = false;
        camera3.enabled = false;
        camera4a.enabled = false;
        camera4b.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;

    }
        void Cam2A()
    {
        camera1a.enabled = false;
        camera1b.enabled = false;
        camera1c.enabled = false;
        camera2a.enabled = true;
        camera2b.enabled = false;
        camera3.enabled = false;
        camera4a.enabled = false;
        camera4b.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;

    }
        void Cam2B()
    {
        camera1a.enabled = false;
        camera1b.enabled = false;
        camera1c.enabled = false;
        camera2a.enabled = false;
        camera2b.enabled = true;
        camera3.enabled = false;
        camera4a.enabled = false;
        camera4b.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;

    }
        void Cam3()
    {
        camera1a.enabled = false;
        camera1b.enabled = false;
        camera1c.enabled = false;
        camera2a.enabled = false;
        camera2b.enabled = false;
        camera3.enabled = true;
        camera4a.enabled = false;
        camera4b.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;

    }
        void Cam4A()
    {
        camera1a.enabled = false;
        camera1b.enabled = false;
        camera1c.enabled = false;
        camera2a.enabled = false;
        camera2b.enabled = false;
        camera3.enabled = false;
        camera4a.enabled = true;
        camera4b.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;

    }
        void Cam4B()
    {
        camera1a.enabled = false;
        camera1b.enabled = false;
        camera1c.enabled = false;
        camera2a.enabled = false;
        camera2b.enabled = false;
        camera3.enabled = false;
        camera4a.enabled = false;
        camera4b.enabled = true;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = false;

    }
            void Cam5()
    {
        camera1a.enabled = false;
        camera1b.enabled = false;
        camera1c.enabled = false;
        camera2a.enabled = false;
        camera2b.enabled = false;
        camera3.enabled = false;
        camera4a.enabled = false;
        camera4b.enabled = false;
        camera5.enabled = true;
        camera6.enabled = false;
        camera7.enabled = false;

    }
            void Cam6()
    {
        camera1a.enabled = false;
        camera1b.enabled = false;
        camera1c.enabled = false;
        camera2a.enabled = false;
        camera2b.enabled = false;
        camera3.enabled = false;
        camera4a.enabled = false;
        camera4b.enabled = false;
        camera5.enabled = false;
        camera6.enabled = true;
        camera7.enabled = false;

    }
            void Cam7()
    {
        camera1a.enabled = false;
        camera1b.enabled = false;
        camera1c.enabled = false;
        camera2a.enabled = false;
        camera2b.enabled = false;
        camera3.enabled = false;
        camera4a.enabled = false;
        camera4b.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        camera7.enabled = true;

    }

}
