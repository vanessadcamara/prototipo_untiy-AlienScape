using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHeadTrigger : MonoBehaviour
{
    
    // box collider
    private BoxCollider2D boxCollider;
    [SerializeField]
    private playerController player;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        
    }

   
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            player.setDead(true);
        }
    }
}   
     