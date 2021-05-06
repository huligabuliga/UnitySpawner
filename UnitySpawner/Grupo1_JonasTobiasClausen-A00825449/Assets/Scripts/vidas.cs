using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidas : MonoBehaviour
{
    public static int vidasCant;
    private Text vidasText;
    // Start is called before the first frame update
    void Start()
    {
        vidasText = GetComponent<Text>();
        vidasCant = 3;
    }

    // Update is called once per frame
    void Update()
    {
        vidasText.text = "Vidas: " + vidasCant;

    }
}
