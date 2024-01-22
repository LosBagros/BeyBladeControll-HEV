using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float forceMultiplier = 10f;
    [SerializeField] private string inputNameHorizontal;
    [SerializeField] private string inputNameVertical;

    private Rigidbody rb;
    private Vector3 inputVector;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float inputHorizontal = Input.GetAxis(inputNameHorizontal);
        float inputVertical = Input.GetAxis(inputNameVertical);

        inputVector = new Vector3(inputHorizontal, 0, inputVertical).normalized;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector3 force = inputVector * speed * forceMultiplier * Time.fixedDeltaTime;
        rb.AddForce(force, ForceMode.VelocityChange);
    }
}
