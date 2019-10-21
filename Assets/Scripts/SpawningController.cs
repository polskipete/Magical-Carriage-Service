using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningController : MonoBehaviour
{
    public GameObject[] obstacleList;
    public int obstacle;
    public Vector3 spawnPoint;
    public float spawnRangeX = 24;
    public float spawnPosZ = 240;
    private float speed;
    private float spawnRate;
    private float spawnAmount = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", 2, 1);
        InvokeRepeating("IncreaseSpawnAmount", 10f, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        speed = GameObject.Find("Road").GetComponent<RoadController>()._speed / 2;

        spawnRate = 5;

       

    }
    void SpawnRandomObstacle()
    {
        Debug.Log(spawnAmount);
        for (var i = 0; i < spawnAmount; i++)
        {
            obstacle = Random.Range(0, obstacleList.Length);
            spawnPoint = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        
            Instantiate(obstacleList[obstacle], spawnPoint, obstacleList[obstacle].transform.rotation);
        }
        
    }

    void IncreaseSpawnAmount() {
        spawnAmount+= 1;
    }
    
}
