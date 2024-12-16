
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLayer : MonoBehaviour
{
    private SpriteRenderer objectLayer;

   
    void Start() // Start is called before the first frame update
    {
        objectLayer = GetComponent<SpriteRenderer>();
    }

    
    void Update() // Update is called once per frame
    {
        if(GameObject.Find("Player").transform.position.y > gameObject.transform.position.y)
        { 
            objectLayer.sortingOrder = 3;
        }
        else
        {
            objectLayer.sortingOrder = 1;
        }
    }
}
