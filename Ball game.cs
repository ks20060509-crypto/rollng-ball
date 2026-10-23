using UnityEngine;

public class Ballgame : MonoBehaviour
{
    public float speed = 10f;
    float x;
    float z;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

         x = Input.GetAxis("Horizontal");
         z = Input.GetAxis("Vertical");


    }

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(x, 0f, z).normalized;

       rb.AddForce(direction * speed);
    }
}

