﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Juuu");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Vozim dinamično!");
    }
}
