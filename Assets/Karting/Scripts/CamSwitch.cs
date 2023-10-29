using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject Camera_1;
    public GameObject Camera_2;
    
    void Update ()
    {
        if (Input.GetButtonDown("1Key"))
        {
            Camera_1.SetActive(true);
            Camera_2.SetActive(false);
        }

        if (Input.GetButtonDown("2Key"))
        {
            Camera_1.SetActive(false);
            Camera_2.SetActive(true);
        }

    }

}