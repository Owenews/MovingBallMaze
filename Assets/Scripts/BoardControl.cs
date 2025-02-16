using UnityEngine;

public class BoardControl : MonoBehaviour
{
    public float rotationSpeed = 50f;
    public float maxRotation = 10f;
    void Start()
    {
        float rotationX = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        float rotationZ = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        Vector3 currentRotation = transform.localEulerAngles;

        if (currentRotation.x > 180f) currentRotation.x -= 360f;
        if (currentRotation.z > 180f) currentRotation.z -= 360f;

        float newRotationX = Mathf.Clamp(currentRotation.x + rotationX, -maxRotation, maxRotation);
        float newRotationZ = Mathf.Clamp(currentRotation.x + rotationZ, -maxRotation, maxRotation);

        transform.localEulerAngles = new Vector3(newRotationX, currentRotation.y, newRotationZ);

    }

}
