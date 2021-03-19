using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Health_System : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public float dmg;

    public GameObject healthBarUI;
    public Slider slider;



    void Start()
    {
        health = maxHealth;
        slider.value = CalculateHealth();
    }

    void Update()
    {
        slider.value = CalculateHealth();

        if (health < maxHealth)
        {
            healthBarUI.SetActive(true);
        }

        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("DeathScene");
        }

        if (health > maxHealth)
        {
            health = maxHealth;
        }



    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("Enemy"))
        {
            Damage();
            Debug.Log("Collides");
        }
    }

    float CalculateHealth()
    {
        return health / maxHealth;
    }

    void Damage()
    {
        health = health - dmg;
    }
}
