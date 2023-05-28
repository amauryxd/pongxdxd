using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barras : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] bool isPaddle1;
    private float yBound = 3.34f;

    // Update is called once per frame
    void Update()
    {
        float movement; // = Input.GetAxisRaw("Vertical");
        if (isPaddle1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        //transform.position += new Vector3(0, movement * speed * Time.deltaTime, 0);
        Vector2 paddlePosition = transform.position;
        paddlePosition.y = Mathf.Clamp(paddlePosition.y + movement * speed * -Time.deltaTime, -yBound, yBound);
        transform.position = paddlePosition;
    }
}
