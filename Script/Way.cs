using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Way : MonoBehaviour
{
    public List<Transform> targetList = new List<Transform>();
    public Transform targetWaypoint;
    private float movementStep;
    public float movementSpeed = 5.0f;
    void Start()
    {
         
    }

    void Update()
    {
        
        targetWaypoint = targetList[1];
        movementStep = movementSpeed * Time.deltaTime;
        gameObject.transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, movementStep);
    }



}