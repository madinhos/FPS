using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour {
    public float speedRotateX = 0.0F;
    public float speedRotateY = 0.0F;
    public float speedRotateZ = 0.0F;
    public float transformSpeed = 0.0f;

    public float delta = 1.5f;  // Amount to move left and right from the start point
    private Vector3 startPos;

    void Start()
    {
        this.startPos = transform.position;

    }

    void Update()
    {


        this.transform.RotateAround(Vector3.zero, this.transform.up, Time.deltaTime * speedRotateX);
        this.transform.RotateAround(Vector3.zero, this.transform.right, Time.deltaTime * speedRotateY);
        this.transform.RotateAround(Vector3.zero, this.transform.forward, Time.deltaTime * speedRotateZ);

        Vector3 v = startPos;
        v.y += delta * Mathf.Sin(Time.time * transformSpeed);
        this.transform.position = v;

    }

}
