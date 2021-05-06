using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour
{

  public Text endgametext;
   public Button restartButton; 
    // Start is called before the first frame update
    void Start()
    {
        endgametext.enabled = false;
        restartButton.gameObject.SetActive(false);
        restartButton.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    // Update is called once per frame
    void Update()
    {
      if(vidas.vidasCant == 0)
        {
            endgametext.enabled = true;
            restartButton.gameObject.SetActive(true);
        }

            
    }

  
}
