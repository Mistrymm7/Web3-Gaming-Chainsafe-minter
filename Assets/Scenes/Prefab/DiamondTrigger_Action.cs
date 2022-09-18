using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondTrigger_Action : MonoBehaviour
{
    
   
    void Start()
    {
        //Debug.Log("Cool");
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Collided from Diagmond");
        gameObject.SetActive(false);
    }
}
