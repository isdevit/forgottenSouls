
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveData : MonoBehaviour
{
    public bool hasSword;
   
    public void playerData()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            hasSword = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>().ActiveSword();
        }
    }

  
    public void moveInventory()
    {
        GlobalControl.hasSword = ApplicationData.hasSword;
        GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>().giveSword();
    }
}
