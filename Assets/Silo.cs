using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using UnityEngine;

public class Silo : MonoBehaviour, IEnterable
{
    public List<Resource> Resources = new List<Resource>();

    public void Enter(GameObject enteringObject)
    {
        var resource = enteringObject.GetComponent<Carry>().Drop();
        Resources.Add(resource);
        Debug.Log("Added resource " + resource.Amount + " " + resource.Type);
        Debug.Log($"New total: {Resources.Sum(x => x.Amount)} of {resource.Type}");
    }
}