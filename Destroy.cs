using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Este codigo hace que se destruya el gameObject en el que se encuentra al principio del juego
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
