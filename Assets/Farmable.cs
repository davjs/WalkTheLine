using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmable : MonoBehaviour
{

	public GameObject Resource;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name.StartsWith("Character"))
		{
			Destroy(col.gameObject);
		}
	}
}
