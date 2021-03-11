using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class TriggerText_ATM : MonoBehaviour
{
   public Canvas myCanvas;

    // Start is called before the first frame update
    void Start()
    {
        myCanvas = myCanvas.GetComponent<Canvas>();
        myCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision coll)
    {
        if(coll.collider.CompareTag("Player"))
        {
            myCanvas.enabled = true;
            Debug.Log("ATM_TEXT");
        }      
    }

     void OnCollisionExit(Collision coll)
    {
       if (coll.collider.CompareTag("Player"))
        {
            myCanvas.enabled = false;
           
        }
    }


}
