using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private SpriteRenderer sr;
    [SerializeField]
    private Camera cam;
    // Start is called before the first frame update
    private int direction = 0;
    private bool isWalkin = false;
    private int directionWalk = 0;
    private int currentRotation = 0;
    private bool dead = false;
    private bool withKey = false;
    
     void Start()
    {
        // Apply force to the player
        setDirection(0);
    }

    void Update()
    {
       
        currentRotation = (int) cam.transform.rotation.eulerAngles.z;

        if (directionWalk == 1)
        {
            // Trasnlate the player to the right
            if(currentRotation == 0){
                gameObject.transform.Translate(0.1f, 0, 0);
            }
            else if(currentRotation == 90){
                gameObject.transform.Translate(0, 0.1f, 0);
            }
            else if(currentRotation == 180){
                gameObject.transform.Translate(-0.1f, 0, 0);
            }
            else if(currentRotation == 270){
                gameObject.transform.Translate(0, -0.1f, 0);
            }
        }
        else if (directionWalk == -1)
        {
            // Trasnlate the player to the left
            if(currentRotation == 0){
                gameObject.transform.Translate(-0.1f, 0, 0);
            }
            else if(currentRotation == 90){
                gameObject.transform.Translate(0, -0.1f, 0);
            }
            else if(currentRotation == 180){
                gameObject.transform.Translate(0.1f, 0, 0);
            }
            else if(currentRotation == 270){
                gameObject.transform.Translate(0, 0.1f, 0);
            }
        }

        switch (direction)
        {
            case 0:
                rb.velocity = new Vector2(0, -10);
                break;
            case 1:
                rb.velocity = new Vector2(10, 0);
                break;
            case 2:
                rb.velocity = new Vector2(0, 10);
                break;
            case 3:
                rb.velocity = new Vector2(-10, 0);
                break;

        }

       
    }

    public void setDirection(int direction)
    {
        this.direction = direction;
  
    }


    public int getDirection()
    {
        return direction;
    }
}
