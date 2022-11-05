using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 1f;
    public float rotationSpeed = 20f;
    public float turbo = 10f;
    public float normal = 6f;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movementDirection = new Vector3(horizontalInput, 0.0f, verticalInput);
        movementDirection.Normalize();

        transform.position = transform.position + movementDirection * speed * Time.deltaTime;
        if (movementDirection != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementDirection), rotationSpeed * Time.deltaTime);
    }

    public void setNormal()
    {
        speed = normal;
    }
    public void setTurbo()
    {
        speed = turbo;
    }
}

