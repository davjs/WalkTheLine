using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmable : MonoBehaviour
{
    public GameObject Resource;

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
        var droneComponent = col.gameObject.GetComponent<Drone>();
        if (droneComponent)
        {
            var switchComponent = GetComponent<Switch>();
            if (switchComponent)
            {
                switchComponent.SwitchRoadForDrone(droneComponent);
            }
        }
    }
}