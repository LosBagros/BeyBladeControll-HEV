using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class naraz : MonoBehaviour
{
    int zivoty;
    Rigidbody rb;

    [SerializeField]
    private AudioClip[] hits;
    private AudioSource audio;

    void Start()
    {
         rb = gameObject.GetComponent<Rigidbody>();
         audio = gameObject.GetComponent<AudioSource>(); 
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody otherRb = collision.gameObject.GetComponent<Rigidbody>();
            if (otherRb != null)
            {
                Vector3 collisionDirection = collision.contacts[0].normal;
                float mySpeed = Vector3.Dot(rb.velocity, collisionDirection);
                float otherSpeed = Vector3.Dot(otherRb.velocity, collisionDirection);

                if (mySpeed >= otherSpeed)
                {
                    Vector3 forceDirection = collisionDirection * 300; //(collisionDirection * (mySpeed - otherSpeed))*100;
                    otherRb.AddForce(forceDirection , ForceMode.Impulse);
                    
                }
            }
            audio.clip = hits[Random.Range(0, hits.Length)];
            audio.Play();

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
