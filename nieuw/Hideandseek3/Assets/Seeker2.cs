﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeker2 : MonoBehaviour
{
    RaycastHit hit;

    
    void Start()
    {
     
    }

 
    void Update()
    {
       // Vector3 v, 


        if (Physics.Raycast(transform.position, transform.forward, out hit, 10000))
        {
            if (hit.collider.gameObject.CompareTag("Hider"))
            {
               
                //   Debug.Log("Gevonden");
                hit.transform.SendMessage("HitByRay");
            }
        }
    }
}
