using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Switch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject atmCam;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cam1"))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        else if (Input.GetButtonDown("Cam2"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }

        else if (Input.GetButtonDown("H_Key"))
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            atmCam.SetActive(true);
        }
    }

    
    
}

