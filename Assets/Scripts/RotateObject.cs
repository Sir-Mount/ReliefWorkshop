using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 50f; // Configurable speed

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around the Y-axis based on the configured speed
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}