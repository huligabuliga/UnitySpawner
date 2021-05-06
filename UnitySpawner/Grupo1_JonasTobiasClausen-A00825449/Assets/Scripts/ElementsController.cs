using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsController : MonoBehaviour
{
    public float speed;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Time.deltaTime * speed *-1, 0);

        if(transform.position.y < -5 )
        {
            Destroy(gameObject);
            if (gameObject.tag == "Rock")
            {
                vidas.vidasCant -= 1;
            }
        }
    }
}
