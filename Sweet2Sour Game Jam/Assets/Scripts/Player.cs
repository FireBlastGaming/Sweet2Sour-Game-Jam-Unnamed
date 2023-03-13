using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float x;
    private float y;

    void Update()
    {
        x = transform.position.x;
        y = transform.position.y;

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector2(x - 1, y);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector2(x + 1, y);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector2(x, y + 1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector2(x, y - 1);
        }
    }
}
