using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float Speed;
    [SerializeField] private string InputNameHorizontal;
    [SerializeField] private string InputNameVertical;

    private Rigidbody rb;
    private float InputHorizontal;
    private float InputVertical;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    public void Update()
    {
        //InputHorizontal = 
    }
}
