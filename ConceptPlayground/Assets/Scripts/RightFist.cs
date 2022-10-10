using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFist : MonoBehaviour
{

    HealthBar hp;//reference to healthbar 

    //For SearchFighter would want on trigger stay for being able to repeaditly hit other player
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            hp = other.gameObject.GetComponent<HealthBar>();
            if(Input.GetKeyUp(KeyCode.D)){
                Debug.Log("Pow!!!");
                hp.LoseHealth(1);
            }
            
        }
    }
}
