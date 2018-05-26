using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Farmable : MonoBehaviour, IEnterable
{
    public string ResourceType = "Berry";
    public int MaxPickUpAmount = 10;

    public void Enter(GameObject enteringObject)
    {
        var droneComponent = enteringObject.GetComponent<Drone>();
        if (droneComponent)
        {
            var switchComponent = GetComponent<Switch>();
            if (switchComponent)
            {
                switchComponent.SwitchRoadForDrone(droneComponent);
            }
        }

        var carryComponent = enteringObject.GetComponent<Carry>();
        if (carryComponent)
        {
            carryComponent.PickUp(ResourceType, MaxPickUpAmount);
        }
    }
}