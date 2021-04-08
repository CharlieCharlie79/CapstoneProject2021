using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score_System : MonoBehaviour
{
    public static int scoreValue = 0;
     Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = " " + scoreValue;  
        
        if(scoreValue >= 150)
        {
            SceneManager.LoadScene("Level_2");
            
            Cursor.lockState = CursorLockMode.Confined; //Locks the mouse
            Cursor.visible = true; // Make the cursor visable
            
        }
    }
}
