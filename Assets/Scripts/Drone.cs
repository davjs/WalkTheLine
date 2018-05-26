using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;


public class Drone : MonoBehaviour
{
    public float Speed = 1;
    public Road Road;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > Road.transform.position.x - Road.transform.localScale.z / 2)
        {
            var originalY = transform.position.y;
            transform.position = Vector3.MoveTowards(transform.position, Road.End.position, Speed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, originalY, transform.position.z);
            //this.GetComponent<Rigidbody>().AddForce(-Speed, 0, 0);
//            transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }
    }
}