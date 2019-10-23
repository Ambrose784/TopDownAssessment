using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public int health = 10;
    public Text HealthText;
    public Slider healthSlider;
    public int lives = 10;
    void Start()
    {
        HealthText.text = "Health:" + health;
        healthSlider.maxValue = health;
        healthSlider.value = health;
        //PlayerPrefs.SetInt("lives", lives);
        lives = PlayerPrefs.GetInt("lives");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Minus")
        {
            health--;
            HealthText.text = "Health:" + health;
            healthSlider.value = health;
            //same as health -= 1, or health = health
            if (health < 1)
            {
                if (lives > 0)
                {

                    //we should be dead, right?
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    //SceneManager.LoadScene("Win");
                    PlayerPrefs.SetInt("lives", lives - 1);
                }
                else
                {
                    SceneManager.LoadScene("GameOver");
                }

            }
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            health--;
            if (health < 1)
            {
                if (lives > 0)
                {

                    //we should be dead, right?
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    //SceneManager.LoadScene("Win");
                    PlayerPrefs.SetInt("lives", lives - 1);
                }
                else
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
        }
    }
}