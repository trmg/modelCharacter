using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickupsManager : MonoBehaviour

{

    public GameObject spiral;
    public GameObject luz1;
    public GameObject luz2;

    public static bool orbCaught = false;

    void OnTriggerEnter(Collider spiral)
    {
        Destroy(luz1.gameObject);
        Destroy(luz2.gameObject);
        Destroy(spiral.gameObject);
        orbCaught = true;
    }

    public static void setOrbToFalse() 
    {
        orbCaught = false;
    } 
}