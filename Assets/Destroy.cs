using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		if(this.gameObject.transform.position.y < -1000) {
            Destroy(this.gameObject);
        }
	}
}
