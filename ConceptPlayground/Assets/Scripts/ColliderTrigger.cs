using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
    //For SearchFighter would want on trigger stay for being able to interact with the object.
    void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
        {
            Debug.Log("Touching");
        }
    }
}
