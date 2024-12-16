
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;

    private Transform target;
    
   
    void Start() // Start is called before the first frame update
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    
   
    void Update() // Update is called once per frame
    {
        if (gameObject.GetComponent<enemyHealth>().isDead == true)
        {
            speed = 0;
        }
        
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
