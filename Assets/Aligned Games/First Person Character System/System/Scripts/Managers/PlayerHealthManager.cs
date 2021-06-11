using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour

{

    public Text HealthText;

    public float CurrentHealth;
    public float MaximumHealth;
    public float MinimumHealth;

    public GameObject RagdollPlayer;

    public float HealthPickupHealFactor;

    public GameObject deadMenuUI;

    public void Start()

    {

        HealthText = GameObject.Find("HealthText").GetComponent<Text>();

    }

    void Update()

    {

        HealthText.text = CurrentHealth.ToString("0");

        if (CurrentHealth >= MaximumHealth)

        {

            CurrentHealth = MaximumHealth;

        }

        if (CurrentHealth <= MinimumHealth)

        {
            deadMenuUI.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            CurrentHealth = MinimumHealth;
            Instantiate(RagdollPlayer, this.transform.position, this.transform.rotation);
            PickupsManager.setOrbToFalse();
            Destroy(this.gameObject);

        }

    }

    public void PickupHeart()

    {

        CurrentHealth += HealthPickupHealFactor;

    }

}