using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] float Scorer;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Games")
        {
            if(Scorer <= 0)
            {
                return;
            }
            Scorer -= 1;
            Debug.Log(Scorer);
        }

    }
}
