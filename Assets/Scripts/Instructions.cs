using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    public GameObject instructionsUI;
    public static bool firstTime = true;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if(firstTime) {
                instructionsUI.SetActive(false);
                
            }
        }
    }
}
