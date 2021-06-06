using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PickupsManager : MonoBehaviour

{

    public Text InfoText;

    public Keyboard Keycodes;

    [System.Serializable]
    public class Keyboard

    {

        public KeyCode Pickup = KeyCode.F;

    }

    public void Start()

    {

        InfoText = GameObject.Find("InfoText").GetComponent<Text>();

    }

    public void OnTriggerStay(Collider other)

    {

        InfoText.text = "Press " + Keycodes.Pickup + " To Pick Up";

        if (other.gameObject.tag == "Pickup")

        {

            InfoText.text = "Press 'F' To Pickup";

            if (other.gameObject.name == "heart_pickup_1")

            {

                if (Input.GetKey(Keycodes.Pickup))

                {

                    if (GetComponent<PlayerHealthManager>().CurrentHealth < GetComponent<PlayerHealthManager>().MaximumHealth)

                    {

                        this.transform.SendMessage("PickupHeart");
                        Destroy(other.gameObject);
                        InfoText.text = "If you die press 'R' to respawn";

                    }

                }

            }

            if (other.gameObject.name == "speed_pickup_1")

            {

                if (Input.GetKey(Keycodes.Pickup))

                {

                    this.transform.SendMessage("PickupSpeed");
                    Destroy(other.gameObject);
                    InfoText.text = "If you die press 'R' to respawn";

                }

            }

            if (other.gameObject.name == "jump_pickup_1")

            {

                if (Input.GetKey(Keycodes.Pickup))

                {

                    this.transform.SendMessage("PickupJump");
                    Destroy(other.gameObject);
                    InfoText.text = "If you die press 'R' to respawn";

                }

            }

        }

        else

        {

            InfoText.text = "If you die press 'R' to respawn";

        }

    }

    public void OnTriggerExit(Collider other)

    {

        InfoText.text = "If you die press 'R' to respawn";

    }

}