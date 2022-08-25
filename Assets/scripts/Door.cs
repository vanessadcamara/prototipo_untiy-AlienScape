using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private BoxCollider2D collider;
    [SerializeField]
    private string scene;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.GetComponent<playerController>().getWithKey())
            {
                SceneManager.LoadScene(scene);
            }
        }
    }

}
