using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplineWalker : MonoBehaviour {

    public CurvedLineRenderer spline;

    public float duration;

    private float progress;
   // private CurvedLinePoint[] linePoints = new CurvedLinePoint[0];

    private void Update()
    {
        progress += Time.deltaTime / duration;
        if (progress > 1f)
        {
            progress = 1f;
        }
        //transform.localPosition = spline.getPositions()[(int)progress];
        Debug.Log("Progress: " + progress);
        //Debug.Log("Line Points: " + spline.getPositions()[0]);
    }
}
