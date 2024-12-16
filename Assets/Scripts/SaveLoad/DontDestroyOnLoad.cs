using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    void Start()
    {
        // Prevent this GameObject from being destroyed when loading new scenes
        DontDestroyOnLoad(gameObject);
    }
}
