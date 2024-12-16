﻿
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class spikeDamage : MonoBehaviour
{
    public int spikeStrength;
    
   
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<playerHealth>().harmPlayer(spikeStrength);
        }
    }

  
    private void disableCollision()
    {
        GetComponent<Collider2D>().enabled = false;
    }
    
   
    private void enableCollision()
    {
        GetComponent<Collider2D>().enabled = true;
    }
}