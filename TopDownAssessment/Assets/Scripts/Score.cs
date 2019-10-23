using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    void Start()
    {
        scoreText.text = "Score:" + score;  
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.tag == "Plus")
        {
            score++;
            scoreText.text = "Score:" + score;
            Destroy(collision.gameObject);
            if (score >= 10)
            {
                SceneManager.LoadScene("Win");
            }
       }
      
        
    }
}
