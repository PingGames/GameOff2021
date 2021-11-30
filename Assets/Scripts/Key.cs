using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // public Animator dooor;
    
    void OnTriggerEnder2D(Collider col)
    {
            Destroy(gameObject);
    }
}
