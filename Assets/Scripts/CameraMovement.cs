

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothingSpeed;
    public objectVector[] maxPosition;
    public objectVector[] minPosition;
    private int index;    //used to move through the object vector array to change the camera's location as
                          //the player moves between rooms
  
    private void Start()
    {
        index = 0;    //initialize to 0
    }

    
    void LateUpdate()
    {
        if (transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x,
                target.position.y,
                transform.position.z);

            targetPosition.x = Mathf.Clamp(targetPosition.x,
                                                minPosition[index].initial.x,
                                                maxPosition[index].initial.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y,
                                                minPosition[index].initial.y,
                                                maxPosition[index].initial.y);
            transform.position = Vector3.Lerp(transform.position,
                targetPosition,
                smoothingSpeed);
        }
    }
    
    public void SetIndex(int newIndex)
    {
        index = newIndex;
    }
}