using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour {

    public int rotationSpeed;
    public bool twoAxisRotation;
    public int rotationSpeed2;

	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);

        if(twoAxisRotation)
        {
            transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed2, Space.World);
        }

    }
}
