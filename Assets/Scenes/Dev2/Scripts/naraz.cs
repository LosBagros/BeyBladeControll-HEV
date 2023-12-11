using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class naraz : MonoBehaviour
{
    int zivoty;
    Rigidbody rb;
    void Start()
    {
         rb = gameObject.GetComponent<Rigidbody>();
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
                    Vector3 forceDirection = collisionDirection * 30;//(collisionDirection * (mySpeed - otherSpeed))*100;
                    otherRb.AddForce(forceDirection , ForceMode.Impulse);
                    
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
