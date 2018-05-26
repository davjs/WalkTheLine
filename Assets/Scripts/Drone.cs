using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;


public class Drone : MonoBehaviour
{
    public float Speed = 1;
    public Road Road;
    public float _progress = 0;
    
    public void ChangeRoad(Road road)
    {
        Road = road;
        _progress = 0;
    }

    void Update()
    {
        if (_progress < 1)
        {
            _progress += Speed * Time.deltaTime;
            var originalY = transform.position.y;
            transform.position = Vector3.Lerp(Road.Start.position, Road.End.position, _progress + 0.1f);
            transform.position = new Vector3(transform.position.x, originalY, transform.position.z);
        }
    }
}