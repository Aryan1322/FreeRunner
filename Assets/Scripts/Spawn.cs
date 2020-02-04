using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obstacle;
    public float shootingSpeed;
    public Rigidbody2D rb2D;


    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.6f;

    private void Update()
    {
        if(timeBtwSpawn <= 0)
        {
            SpawnFireBall();
            timeBtwSpawn = startTimeBtwSpawn;
            if(startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
            
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }

    void SpawnFireBall()
    {
        GameObject fireballProject = Instantiate(obstacle, transform.position, Quaternion.identity) as GameObject;

        rb2D = fireballProject.GetComponent<Rigidbody2D>();
        rb2D.AddForce(Vector3.left * shootingSpeed * Time.deltaTime);

    }

}
