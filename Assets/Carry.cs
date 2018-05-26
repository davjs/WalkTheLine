using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.XR.WSA.Persistence;

public class Carry : MonoBehaviour
{
    private int _amount;
    private string _resourceType;

    public void PickUp(string type, int amount)
    {
        this._amount = amount;
        this._resourceType = type;
    }

    public Resource Drop()
    {
        var resource = new Resource
        {
            Amount = _amount,
            Type = _resourceType
        };
        _amount = 0;
        _resourceType = "";
        return resource;
    }
}