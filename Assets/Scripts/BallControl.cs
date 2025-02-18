using UnityEngine;

public class BallControl : MonoBehaviour
{
    private readonly float speed = 2.0f;
    private Rigidbody rb;

    public Transform respawnPoint;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0, moveZ);

        rb.AddForce(movement * speed);

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger : " + other.gameObject.tag);

        if (other.gameObject.tag == "FinishZone")
        {
            rb.isKinematic = true;
            transform.position = respawnPoint.position;
            rb.isKinematic = false;
        }

        else if (other.gameObject.tag == "Obstacle")
        {
            rb.isKinematic = true;
            transform.position = respawnPoint.position;
            rb.isKinematic = false;
        }
    }


}
