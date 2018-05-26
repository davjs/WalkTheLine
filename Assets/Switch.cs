using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Switch : MonoBehaviour
{
    public Road RoadA;
    public Road RoadB;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SwitchRoadForDrone(Drone drone)
    {
        var newRoad = drone.Road == RoadA ? RoadB : RoadA;
        drone.ChangeRoad(newRoad);
    }
}