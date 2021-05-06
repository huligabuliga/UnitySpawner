using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public static int puntosCant;
    private Text puntosText;


    // Start is called before the first frame update
    void Start()
    {
        puntosText = GetComponent<Text>();
        puntosCant = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        puntosText.text = "Puntos: " + puntosCant; 
    }
}
