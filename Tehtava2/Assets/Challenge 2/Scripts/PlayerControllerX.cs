using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireRate = 1; // time player has to wait for another shot.
    private float nextFire = 0; 

    // Update is called once per frame
    void Update()
    {
        // On spacebar press if enough time has passed send another dog.
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate; // reset time
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
