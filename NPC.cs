using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Vida del NPC
    public int health = 5;
    //Nivel del NPC
    public int level = 4;
    //velocidad del NPC
    public float speed = 1.2f;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Vida jugador:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;

    }
}
