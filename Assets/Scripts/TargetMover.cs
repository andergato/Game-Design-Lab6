using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    public int moveSpeed = 0;

    public int boundary = 0;
    private float offset = 0;
    private int direction = 1;

    private float moveValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(Math.Abs(offset) >= boundary)
        {
            direction *= -1;
        }
        moveValue = direction * moveSpeed * Time.deltaTime;
        moveObject();
    }

    private void moveObject()
    {
        offset += moveValue;
        transform.Translate(Vector3.right * moveValue,Space.World);
    }
}
