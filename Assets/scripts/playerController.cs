using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Atributes
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private SpriteRenderer sr;
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private GameObject painelDead;
    [SerializeField]
    private GameObject painelWin;

    private int direction = 0;
    private bool isWalkin = false;
    private int directionWalk = 0;
    private int currentRotation = 0;
    private bool dead = false;
    private bool withKey = false;
    // Start is called before the first frame update
    void Start()
    {
        // Apply force to the player
        setDirection(0);
    }
    public void Move(int horizontal){
        directionWalk = horizontal;
    }

    public void setWithKey(bool key){
        withKey = key;
    }
    public bool getWithKey(){
        return withKey;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (dead)
        {
            return;
        }
        currentRotation = (int) cam.transform.rotation.eulerAngles.z;

        if (directionWalk == 1)
        {
            // Trasnlate the player to the right
            gameObject.transform.Translate(0.1f, 0, 0);
            
        }
        else if (directionWalk == -1)
        {
            // Trasnlate the player to the left
            gameObject.transform.Translate(-0.1f, 0, 0);
        }

        switch (direction)
        {
            case 0:
                rb.velocity = new Vector2(0, -10);
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case 1:
                rb.velocity = new Vector2(10, 0);
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
            case 2:
                rb.velocity = new Vector2(0, 10);
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
                break;
            case 3:
                rb.velocity = new Vector2(-10, 0);
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 270);
                break;

        }

       
    }

    public void setDirection(int direction)
    {
        this.direction = direction;
  
    }

    public void setDead(bool dead)
    {
        this.dead = dead;
        painelDead.SetActive(dead);
        Debug.Log("M");
    }

    public int getDirection()
    {
        return direction;
    }

   
    
}
