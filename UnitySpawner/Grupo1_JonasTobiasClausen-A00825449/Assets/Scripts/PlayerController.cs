using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    float movement;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    private void Update()
    {
        movement = Input.GetAxis("Horizontal");
        transform.Translate(movement * Time.deltaTime * speed , 0, 0);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9,9), transform.position.y, transform.position.z);
    }
}
