using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Rigidbody rg;

    [SerializeField] float movespeed = 10f;

    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float X = Input.GetAxis("Horizontal") * movespeed;
        float Z = Input.GetAxis("Vertical") * movespeed;
        rg.velocity = new Vector3(X,0,Z);
    }
}
