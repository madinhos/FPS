using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{

    public playerHealth pH;
    Image health;
    public Text healthBarValue;

    // Use this for initialization
    void Start()
    {
        health = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        health.fillAmount = pH.currentHealth / 100.0f;
        healthBarValue.text = pH.currentHealth + "%";
    }


}
