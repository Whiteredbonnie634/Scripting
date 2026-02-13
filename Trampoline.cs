using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    //Define por cuanto se multiplica la fuerza del salto
    public float JumpFactor = 5f;

    private void OnTriggerEnter(Collider other)
    {
        //Multiplica el salto por JumpFactor
        other.GetComponent<Jump>().jumpStrength *= JumpFactor;
    }
    private void OnTriggerExit(Collider other)
    {
        //quita el aumento del salto
        other.GetComponent<Jump>().jumpStrength /= JumpFactor;
    }
}
