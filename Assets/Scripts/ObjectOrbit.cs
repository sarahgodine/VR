using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOrbit : MonoBehaviour {
	
	public int OrbitSpeed;

	void Update ()
    {
        transform.RotateAround(transform.parent.position, Vector3.up, OrbitSpeed * Time.deltaTime);
    }
}
