using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Image P2HealthBar;


    public float maxHealth = 10;
    private float P2Health;

    void Start(){
        P2Health = maxHealth;
    }

    public void LoseHealth(float hitPower){
        P2Health -= hitPower;
        UpdateHealth(5, P2Health);
    }

    public void UpdateHealth(float mHealth, float CHealth){
        P2HealthBar.fillAmount = CHealth / mHealth;
    }
    

}
