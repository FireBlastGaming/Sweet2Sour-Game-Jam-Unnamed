using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 1.0f;

    void Update()
    {

       speed -= Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            if (speed < 0)
            {
                transform.position += new Vector3(-1, 0, 0);
            }
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (speed < 0)
            {
                transform.position += new Vector3(1, 0, 0);
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (speed < 0)
            {
                transform.position += new Vector3(0, 1, 0);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (speed < 0)
            {
                transform.position += new Vector3(0, -1, 0);
            }
        }
    }
}
