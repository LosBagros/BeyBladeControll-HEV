using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceTrap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody otherRb = collision.gameObject.GetComponent<Rigidbody>();
            if (otherRb != null)
            {
                Vector3 collisionDirection = collision.contacts[0].normal;
                
                    float otherSpeed = Vector3.Dot(otherRb.velocity, collisionDirection);

                
                
                    Vector3 forceDirection = collisionDirection * 50;
                    otherRb.AddForce(forceDirection, ForceMode.Impulse);

                
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
