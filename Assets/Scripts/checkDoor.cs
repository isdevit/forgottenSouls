
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkDoor : MonoBehaviour
{

    private int numEnemies;
    private GameObject[] enemies;
    private bool enemySpawned;
    private Animator animator;
    public GameObject player;
    public GameObject door;

    
    void Start()
    {
        animator = GetComponent<Animator>();
        numEnemies = 0;
        enemySpawned = false;
    }

   
    void Update() // Update is called once per frame
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy1");
        
        if (enemies.Length > 0)
        {
            enemySpawned = true;
        }

        if (enemySpawned)
        {
            if (enemies.Length == 0)        //at this point all enemies are dead
            {
                animator.SetBool("allEnemiesDead",true);
                Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), door.GetComponent<Collider2D>());
            }
        }
    }
    
}
