using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class House : MonoBehaviour, IEnterable
{
    public int SecondsAsleep = 10;
    private float _secondsSinceLastWoke;

    public float LeaveRate = 1;
    private float _secondsSinceLastLeft;

    private Stack<Drone> Drones = new Stack<Drone>();

    void Update()
    {
        _secondsSinceLastWoke += Time.deltaTime;
        _secondsSinceLastLeft += Time.deltaTime;
        if (_secondsSinceLastWoke > SecondsAsleep)
        {
            if (Drones.Count > 0)
            {
                if (_secondsSinceLastLeft > LeaveRate)
                {
                    var drone = Drones.Pop();
                    GetComponent<Switch>().SwitchRoadForDrone(drone);

                    _secondsSinceLastLeft = 0;
                }
                else
                {
                    _secondsSinceLastLeft += Time.deltaTime;
                }
            }
            else
            {
                _secondsSinceLastWoke = 0;
            }
        }
        else
        {
            _secondsSinceLastWoke += Time.deltaTime;
        }
    }


    public void Enter(GameObject enteringObject)
    {
        var drone = enteringObject.GetComponent<Drone>();
        if (drone)
        {
            Drones.Push(drone);
        }
    }
}