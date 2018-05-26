using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using DefaultNamespace;
using UnityEngine;


public class Drone : MonoBehaviour
{
    public float Speed = 1;
    public Road Road;
    private float _progress = 0;
    private bool _isMoving = false;

    public void ChangeRoad(Road road)
    {
        Road = road;
        _progress = 0;
    }

    void Update()
    {
        if (_progress < 1)
        {
            _isMoving = true;
            _progress += Speed * Time.deltaTime;
            var originalY = transform.position.y;
            transform.position = Vector3.Lerp(Road.Start.position, Road.End.position, _progress + 0.1f);
            transform.position = new Vector3(transform.position.x, originalY, transform.position.z);
        }
        else if (_isMoving)
        {
            foreach (var component in Road.ObjectAtEnd.GetComponents(typeof(Component)))
            {
                if (component is IEnterable)
                {
                    (component as IEnterable).Enter(gameObject);
                }
            }

            _isMoving = false;
        }
    }
}