using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid : MonoBehaviour {

    public GameObject AsteroidPrefab;
    public Vector3 center;
    public Vector3 size;
    public float period = 0.0f;
    public int asteroidAmount;
    public float spawnperiod;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (period > spawnperiod) {
            //Do Stuff
            for (int i = 0; i < asteroidAmount; i++)
            {
                SpawnIt();
            }
           
            period = 0;
        }
        period += UnityEngine.Time.deltaTime;
    }

    public void SpawnIt() {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        GameObject obj = (GameObject)Instantiate(AsteroidPrefab, pos, Quaternion.identity);
        obj.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), Random.Range(-100, 100));
        obj.GetComponent<Rigidbody>().angularVelocity = new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), Random.Range(-100, 100));
        float scale = Random.Range(1.0f, 10.0f);
        obj.transform.localScale = new Vector3(scale, scale, scale);
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = new Color(1.0f, 0, 0, 1.0f);
        Gizmos.DrawCube(center, size);
    }
}
