using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;
    //Hace que suceda algo al tocar el Box collider
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }
    //Elimina la velocidad extra
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
