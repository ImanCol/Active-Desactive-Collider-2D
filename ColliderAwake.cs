using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Cambia "ColliderAwake" por el nombre que le pusistes al Script
public class ColliderAwake : MonoBehaviour
{
    public BoxCollider2D platform;
    public bool oneWay = false;


    // Update is called once per frame
    void Update()
    {
        platform.enabled = !oneWay;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        oneWay = true;
    }


    void OnTriggerExit2D(Collider2D other)
    {
        oneWay = false;
    }
}
