using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject deathEffect;

    void OnCollisionEnter(Collision col)
    {
        if(col.collider.tag == "Enemy")
        {
            Instantiate(deathEffect, transform.position, transform.rotation);
            //GameManager.instance.EndGame();

            FindObjectOfType<AudioManager>().Play("PlayerDeath");

            Destroy(gameObject);
        }
    }
}
