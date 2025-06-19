using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningNightlordAttack : MonoBehaviour
{
    public Transform pivotPoint;
    public float rotationSpeed = 10f;

    void Start()
    {

    }

    void Update()
    {
        if (pivotPoint != null)
        {
            transform.RotateAround(pivotPoint.position, Vector3.forward, rotationSpeed * Time.deltaTime);
        }
    }
}
