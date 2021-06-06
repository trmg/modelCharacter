using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManager : MonoBehaviour

{

    public float Damage;

    public void OnTriggerStay(Collider other)

    {

        if (other.gameObject.tag == "Player")

        {

            other.GetComponent<PlayerHealthManager>().CurrentHealth -= Damage;

        }

    }

}