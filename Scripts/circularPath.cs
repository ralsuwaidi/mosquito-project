using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circularPath : MonoBehaviour {

    float timeCounter = 0;
    public float vx;
    public float vy;
    public float vz;
    public float rad;
    public float speed;
    public Transform LookAtTarget;

    void Update()
    {
        transform.LookAt(LookAtTarget);
        timeCounter += Time.deltaTime*speed;
        float x = Mathf.Cos(timeCounter)*rad;
        float y = 0;
        float z = Mathf.Sin(timeCounter)*rad;
        transform.position = new Vector3(x+vx, y+vy, z+vz);
    }


}
