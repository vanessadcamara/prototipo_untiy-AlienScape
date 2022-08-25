using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    // Atributes
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private playerController player;
    [SerializeField]
    private BoxController box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // input keys
        // arrows
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Rotate cam 90 degrees to the right
            cam.transform.Rotate(0, 0, 90);
            // Rotate player 90 degrees to the right
            if (player.getDirection() == 0)
            {
                player.setDirection(1);
                box.setDirection(1);
            }
            else if (player.getDirection() == 1)
            {
                player.setDirection(2);
                box.setDirection(2);
            }
            else if (player.getDirection() == 2)
            {
                player.setDirection(3);
                box.setDirection(3);
            }
            else if (player.getDirection() == 3)
            {
                player.setDirection(0);
                box.setDirection(0);
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Rotate cam 90 degrees to the left
            cam.transform.Rotate(0, 0, -90);
            // Rotate player 90 degrees to the left
            if (player.getDirection() == 0)
            {
                player.setDirection(3);
                box.setDirection(3);
            }
            else if (player.getDirection() == 1)
            {
                player.setDirection(0);
                box.setDirection(0);
            }
            else if (player.getDirection() == 2)
            {
                player.setDirection(1);
                box.setDirection(1);
            }
            else if (player.getDirection() == 3)
            {
                player.setDirection(2);
                box.setDirection(2);
            }
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            player.Move(-1);
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow)){
            player.Move(0);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            player.Move(1);
        }
        if(Input.GetKeyUp(KeyCode.RightArrow)){
            player.Move(0);
        }
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

        

}
