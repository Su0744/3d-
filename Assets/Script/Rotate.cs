using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float Xspeed;
    [SerializeField] float Yspeed;
    [SerializeField] float Zspeed;

    void Update()
    {
        transform.Rotate(Xspeed,Yspeed,Zspeed);
    }
}
