
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    public objectVector teleportLocation;
    
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other != null)
        {
            other.gameObject.GetComponent<Transform>().position = teleportLocation.initial;    //teleport player to next room
        }
    }
}
