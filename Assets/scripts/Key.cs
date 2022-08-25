using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called before the first frame update
    private CircleCollider2D collider;

    void Start()
    {
        collider = GetComponent<CircleCollider2D>();
        
    }

    // Update is called once per fram

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<playerController>().setWithKey(true);
            Destroy(gameObject);
        }
    }
    
}
