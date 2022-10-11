using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;


public class RightFist : MonoBehaviour
{

    HealthBar hp;//reference to healthbar 
    public Animator P1Anim; 


    void Update(){
        if(Input.GetKeyUp(KeyCode.Q)){
            P1Anim.SetTrigger("PunchR");
            }
    }
    //For SearchFighter would want on trigger stay for being able to repeaditly hit other player
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            hp = other.gameObject.GetComponent<HealthBar>();
            hp.LoseHealth(.3f);
            
        }
    }
}
