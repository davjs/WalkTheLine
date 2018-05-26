using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.Analytics;

public class Switch : MonoBehaviour, IEnterable, ILeavable
{
    public Road RoadA;
    public Road RoadB;

    public void SwitchRoadForDrone(Drone drone)
    {
        var newRoad = drone.Road == RoadA ? RoadB : RoadA;
        Debug.Log("Switching to road " + newRoad.gameObject.name);
        drone.ChangeRoad(newRoad);
    }

    public void Enter(GameObject enteringObject)
    {
        enteringObject.SetActive(false);
    }

    public void Leave(GameObject enteringObject)
    {
        enteringObject.SetActive(true);
    }
}