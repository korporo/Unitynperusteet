using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGoalkeeper : MonoBehaviour
{
    Vector3 pointA = new Vector3(10,0,20);
    Vector3 pointB = new Vector3(-10,0,20);

    private Rigidbody goalkeeperRb;

    // Start is called before the first frame update
    void Start()
    {
        goalkeeperRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }

}