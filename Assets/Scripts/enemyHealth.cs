

using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
public class enemyHealth : MonoBehaviour
{

    public double enemy_health;
    public int enemyStrength;
    public bool isDead; 
    private Rigidbody2D myRigidbody;
    private Animator animator;
    
   
    void Start()  // Start is called before the first frame update
    {
        animator = GetComponent<Animator>();
        isDead = false;
    }

  
    void Update()  // Update is called once per frame
    {
        if (enemy_health <= 0.0)
        {
            isDead = true;
            animator.SetBool("enemyDead", isDead);
        }
    }
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("swordHitbox") && enemy_health > 0.0)
        {
            enemy_health -= 1.0;

            Vector2 difference = transform.position - other.transform.position;
            transform.position = new Vector2(transform.position.x + difference.x, transform.position.y + difference.y);
        }
    }
    
    
    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player") && isDead != true)
        {
            Vector2 difference = other.transform.position - transform.position;
            other.transform.position = new Vector2(other.transform.position.x + difference.x, other.transform.position.y + difference.y);
        } 
    }
    
   
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<playerHealth>().harmPlayer(enemyStrength);
        }
    }

    
    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }
    
  
    private void deathAnimation()
    {
        enemyStrength = 0;
    }
    
    
    
}
