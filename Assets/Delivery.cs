using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRender;

    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D otherr)
    {
        Debug.Log("Juuu");
    }

    void OnTriggerEnter2D(Collider2D otherr)
    {
        if (otherr.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            spriteRender.color = hasPackageColor;
            Destroy(otherr.gameObject, destroyDelay);
            Debug.Log("Paket je preuzet");
        }


        else if (otherr.tag == "Customer" && hasPackage)
        {
            spriteRender.color = noPackageColor;
            Debug.Log("Paket je dostavljen kupcu");
            hasPackage = false;
        }
    }
}
