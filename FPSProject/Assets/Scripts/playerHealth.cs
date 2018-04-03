using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour {

    public const int maxHealth = 100;
    public int currentHealth = maxHealth;

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Dead!");
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Aid")
        {
       

            if (currentHealth <= 80)
            {
                currentHealth += 20;
                Destroy(col.gameObject);
            }                
            else if(currentHealth < 100)
            {
                currentHealth = 100;
                Destroy(col.gameObject);
            }        

        }

    }
}
