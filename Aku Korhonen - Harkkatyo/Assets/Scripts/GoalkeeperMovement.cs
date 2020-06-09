using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalkeeperMovement : MonoBehaviour
{
    public Vector3 posA = new Vector3(8, 0, 12);
    public Vector3 posB = new Vector3(-8, 0, 12);
    private float speed = 1.0f;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(posA, posB, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}