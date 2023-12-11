using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float TurnSpeed = 180f;
    [SerializeField] private string InputNameHorizontal;
    [SerializeField] private string InputNameVertical;
    private int boostSpeed;
    private Rigidbody rb;
    private float inputHorizontal;
    private float inputVertical;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        boost.boostEvent.AddListener(prvniZmena);
    }

    private void Update()
    {
        inputHorizontal = Input.GetAxis(InputNameHorizontal);
        inputVertical = Input.GetAxis(InputNameVertical);
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        
        // Pohyb vpøed, vzad a stranami
        Vector3 move = new Vector3(inputHorizontal, 0, inputVertical) * Speed * boostSpeed * Time.deltaTime;

        // Aplikace pohybu
        rb.MovePosition(rb.position + move);
    }
    void prvniZmena(GameObject go)
    {
        if(go == gameObject)
        {
            boostSpeed = 2;
            StartCoroutine(Zmena());
        }
    }
    private IEnumerator Zmena()
    {
        boostSpeed = 0;
        yield return new WaitForSeconds(3f);
    }
}
