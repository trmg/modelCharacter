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
            newTryMenuUI.SetActive(true);
            
        }
        if(hitObject.tag == "Player" && PickupsManager.orbCaught) {
            winMenuUI.SetActive(true);
        }
    }

}
