using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int Health = 5;
    public GameObject Plus;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            Health--;
            if(Health < 1)
            {
                Destroy(gameObject);
                Instantiate(Plus, transform.position, Quaternion.identity);
            }
        }
    }  
      

}
