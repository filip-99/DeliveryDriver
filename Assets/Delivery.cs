using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D otherr)
    {
        Debug.Log("Juuu");
    }

    void OnTriggerEnter2D(Collider2D otherr)
    {
        if (otherr.tag == "Package")
            Debug.Log("Paket je preuzet");


        else if (otherr.tag == "Customer")
            Debug.Log("Paket je dostavljen kupcu");
    }
}
