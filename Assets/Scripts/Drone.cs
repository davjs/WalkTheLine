using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;


public class Drone : MonoBehaviour
{
    public float Speed = 1;
    public GameObject Road;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > Road.transform.position.x - Road.transform.localScale.z / 2)
        {
            //this.GetComponent<Rigidbody>().AddForce(-Speed, 0, 0);
            transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }
    }
}