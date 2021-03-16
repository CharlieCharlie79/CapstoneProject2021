using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Loader : MonoBehaviour
{

     void OnCollisionEnter(Collision coll)
    {
        if(coll.collider.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level_1");
        }
    }
}
