using UnityEngine;

public class AutoCameraRotate : MonoBehaviour
{
    public float rotationSpeed = 50.0f;

    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
