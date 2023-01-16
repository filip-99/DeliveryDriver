using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float destroyDelay = 0.5f;

    void OnCollisionEnter2D(Collision2D otherr)
    {
        Debug.Log("Juuu");
    }

    void OnTriggerEnter2D(Collider2D otherr)
    {
        if (otherr.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            Destroy(otherr.gameObject, destroyDelay);
            Debug.Log("Paket je preuzet");
        }


        else if (otherr.tag == "Customer" && hasPackage)
        {
            Debug.Log("Paket je dostavljen kupcu");
            hasPackage = false;
        }
    }
}
