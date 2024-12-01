using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float times;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= times) {
            GetComponent<MeshRenderer>().enabled = true;
            rb.useGravity = true;
        }
    }
}
