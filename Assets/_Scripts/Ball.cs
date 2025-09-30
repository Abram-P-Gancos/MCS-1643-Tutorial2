using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioClip bouncedSound;
    public float speed = 36.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 90, 0);
        rb = GetComponent<Rigidbody>();

        //create random angle

        float angle = Random.value * 44 - 22; //-22 to 22

        //decide if it's going left or right

        if(Random.value < .5f)
        {
            angle += 90;
        }

        //set the ball to the angle
        transform.eulerAngles = new Vector3(0, angle, 0);

        //give it forward speed
        rb.velocity = transform.forward * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.transform.CompareTag("Floor"))
        {
            AudioSource.PlayClipAtPoint(bouncedSound, transform.position, 1.0f);
        }
    }
}
