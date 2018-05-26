using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmable : MonoBehaviour
{
    public string ResourceType = "Berry";
    public int MaxPickUpAmount = 10;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision col)
    {
        var collidedWithObject = col.gameObject;
        var droneComponent = collidedWithObject.GetComponent<Drone>();
        if (droneComponent)
        {
            var switchComponent = GetComponent<Switch>();
            if (switchComponent)
            {
                switchComponent.SwitchRoadForDrone(droneComponent);
            }
        }

        var carryComponent = collidedWithObject.GetComponent<Carry>();
        if (carryComponent)
        {
            carryComponent.PickUp(ResourceType, MaxPickUpAmount);
        }
    }
}