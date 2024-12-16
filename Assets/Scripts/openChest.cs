

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openChest : MonoBehaviour
{

    public string tagName;
    public GameObject[] objects;
    public GameObject Enemy;
    private bool chestOpen;
    private GameObject Item;        //choosing which item the enemy
    private Collider2D  Player;
    private Animator anim; 
    
    
    void Start() // Start is called before the first frame update
    {
        chestOpen = false;
        anim = GetComponent<Animator>();
    }
    
  
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.CompareTag(tagName) && Input.GetKeyDown("space") && !chestOpen)
        {
            anim.SetBool("isOpened", true);
            chestIsOpen();
            Player = other;
        }
    }
    
    
    private void chestIsOpen()
    {
        chestOpen = true;
      
    }
    
    
    private void spawnEnemy()
    {
        Instantiate(Enemy);
    }

    
    private void giveSword()
    {
        if (Player != null)
        {
            Player.GetComponent<inventory>().giveSword();
        }
    }


}
