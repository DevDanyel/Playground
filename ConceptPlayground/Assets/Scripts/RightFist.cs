using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFist : MonoBehaviour
{
    //For SearchFighter would want on trigger stay for being able to repeaditly hit other player
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            if(Input.GetKeyDown(KeyCode.D)){
                Debug.Log("Pow!!!");
            }
            
        }
    }
}
