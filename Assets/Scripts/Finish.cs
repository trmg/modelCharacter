using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;


public class Finish : MonoBehaviour
{
    public GameObject winMenuUI;
    public GameObject newTryMenuUI;

    void OnTriggerEnter(Collider collider)
    {
        GameObject hitObject = collider.gameObject;

        if(hitObject.tag == "Player" && !PickupsManager.orbCaught) {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            newTryMenuUI.SetActive(true);
            
        }
        if(hitObject.tag == "Player" && PickupsManager.orbCaught) {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            winMenuUI.SetActive(true);
        }
    }

}
