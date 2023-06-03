using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] private float initialVelocity;
    [SerializeField] private float velocityMultiplayer;

    private Rigidbody2D ballRb;

    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        Launch();
    }

    private void Launch()
    {
        float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        ballRb.velocity = new Vector2(xVelocity, yVelocity) * initialVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ballRb.velocity *= velocityMultiplayer;
        source.Play();
        source.pitch = Random.Range(2,4);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal1"))
        {
            GameManager.Instance.Barra2Scored();
            GameManager.Instance.Restart();
            Launch();
        }
        else
        {
            GameManager.Instance.Barra1Scored();
            GameManager.Instance.Restart();
            Launch();
        }
    }

}
