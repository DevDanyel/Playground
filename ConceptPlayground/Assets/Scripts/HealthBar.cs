using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    public int P2Health = 5;


    public void LoseHealth(int hitPower){
        P2Health -= hitPower;
    }
    
}
