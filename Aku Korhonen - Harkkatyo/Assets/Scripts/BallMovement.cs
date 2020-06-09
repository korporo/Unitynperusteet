using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{

    public float speed = 20.0f;
    private float topBound = 30.0f;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // In this if-statement, ball is destroyed if it passes the topbound.
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        // If the ball collides with sensor inside the goal add 1 to the scorecounter. 
        if (other.gameObject.CompareTag("GoalLine"))
        {
            Destroy(gameObject);
            gameManager.UpdateScore(1);
        }
        

        // If the ball collides with the goalkeeper add 1 to the savecounter.
        if (other.gameObject.CompareTag("goalKeeper"))
        {
            Destroy(gameObject);
            gameManager.SaveCounter(1);
        }
    }
}
