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

    private new AudioSource audio;

    private float cooldown = 1f;
    private float colldownTime = 1f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        audio = gameObject.GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && cooldown >= colldownTime)
        {
            cooldown = 0f;
            Rigidbody otherRb = collision.gameObject.GetComponent<Rigidbody>();
            if (otherRb != null)
            {
                Vector3 collisionDirection = collision.contacts[0].normal;
                float mySpeed = Vector3.Dot(rb.velocity, collisionDirection);
                float otherSpeed = Vector3.Dot(otherRb.velocity, collisionDirection);


                if (mySpeed >= otherSpeed)
                {
                    Vector3 forceDirection = collisionDirection * 300;
                    otherRb.AddForce(forceDirection, ForceMode.Impulse);
                }
            }
            if (hits.Length > 0)
            {
                audio.clip = hits[Random.Range(0, hits.Length - 1)];
                audio.Play();
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (cooldown <= colldownTime)
        {
            cooldown += Time.deltaTime;
            Debug.Log(cooldown);
        }
    }
}
