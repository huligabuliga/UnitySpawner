using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    float movement;
    float scale;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        
    }
    private void Update()
    {
        movement = Input.GetAxis("Horizontal");
        transform.Translate(movement * Time.deltaTime * speed , 0, 0);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9,9), transform.position.y, transform.position.z);

        transform.localScale += new Vector3(0f, 0f, 0f);



    }
    private void OnTriggerEnter(Collider other)
    {
        //Si other.tag == “Rock”, Detroy(other.gameObject)
        if (other.tag == "Rock")
        {
            Destroy(other.gameObject);
            Score.puntosCant += 1;

        }

        //Si other.tag == “Power”, crear un nuevo Vector3 y duplicar el valor en x para transform.scale
        if(other.tag == "Power")
        {
            
            Vector3 add = new Vector3(0f, 0f, 0f);
            transform.localScale += new Vector3(transform.localScale.x *2 , 0f, 0f);
            StartCoroutine(powerTimer());
        }
        IEnumerator powerTimer()
        {
            yield return new WaitForSeconds(6f);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if(other.tag == "Meteoritos")
        {
            speed = speed / 2;
            StartCoroutine(meteorTimer());
        }
        IEnumerator meteorTimer()
        {
            yield return new WaitForSeconds(5f);
            speed = 10;
        }
    }
}
