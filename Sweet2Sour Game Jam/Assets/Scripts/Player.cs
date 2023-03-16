using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float buffer;
    

    void Update()
    {
        //The code inside is only run when the key "A" is clicked 
        if (Input.GetKey(KeyCode.A))
        {
            //This if statement counts down the buffer. When the buffer is 0 then it moves the player and sets the buffer to 0.5s
            if (buffer > 0)
            {
                buffer -= Time.deltaTime;
            } 
            else
            {
                transform.position += new Vector3(-1, 0, 0);
                buffer = 0.55f;
                    
            }
            
        }
        //The code inside is only run when the key "D" is clicked 
        if (Input.GetKey(KeyCode.D))
        {
            //This if statement counts down the buffer. When the buffer is 0 then it moves the player and sets the buffer to 0.5s
            if (buffer > 0)
            {
                buffer -= Time.deltaTime;
            }
            else
            {
                transform.position += new Vector3(1, 0, 0);
                buffer = 0.55f;
            }

        }
        //The code inside is only run when the key "W" is clicked 
        if (Input.GetKey(KeyCode.W))
        {
            //This if statement counts down the buffer. When the buffer is 0 then it moves the player and sets the buffer to 0.5s
            if (buffer > 0)
            {
                buffer -= Time.deltaTime;
            }
            else
            {
                transform.position += new Vector3(0, 1, 0);
                buffer = 0.55f;

            }
            

        }
        //The code inside is only run when the key "S" is clicked 
        if (Input.GetKey(KeyCode.S))
        {
            //This if statement counts down the buffer. When the buffer is 0 then it moves the player and sets the buffer to 0.5s
            if (buffer > 0)
            {
                buffer -= Time.deltaTime;
            }
            else
            {
                transform.position += new Vector3(0, -1, 0);
                buffer = 0.55f;
                    
            }
        

        }
    }
}
