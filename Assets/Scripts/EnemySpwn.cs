using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject[] prize;
    public GameObject[] enemy2;
    // Start is called before the first frame update
    void Start()
    {
        // enemy spawn
        InvokeRepeating("SpawnObstacle", 0f, 2.0f);
        InvokeRepeating("SpawnObstacle2", 20.0f, 2.0f);
        InvokeRepeating("SpawnObstacle3", 40.0f, 2.0f);
        InvokeRepeating("SpawnObstacle4", 60.0f, 2.0f);
        InvokeRepeating("SpawnObstacle5", 80.0f, 2.0f);
        InvokeRepeating("SpawnObstacle6", 100.0f, 2.0f);
        InvokeRepeating("SpawnObstacle7", 120.0f, 2.0f);
        // prize spawn
        InvokeRepeating("SpawnObstaclePrize", 0f, 2.0f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstaclePrize()
    {
        int RasGeleMeyve = Random.Range(0, prize.Length);
        float rndNumber_x = Random.Range(-5, 5);
        Vector3 spawnPos = new Vector3(rndNumber_x, 0.6f, 45);
        Instantiate(prize[RasGeleMeyve], spawnPos, enemy.transform.rotation);
    }
    void SpawnObstacle()
    {
        float rndNumber_x = Random.Range(-5,5);
        Vector3 spawnPos = new Vector3(rndNumber_x, 0.6f, 50);
        Instantiate(enemy, spawnPos, enemy.transform.rotation);
    }
    void SpawnObstacle2()
    {
        float rndNumber_x = Random.Range(-5, 5);
        Vector3 spawnPos = new Vector3(rndNumber_x, 0.6f, 55);
        Instantiate(enemy, spawnPos, enemy.transform.rotation);
    }
    void SpawnObstacle3()
    {
        float rndNumber_x = Random.Range(-5, 5);
        Vector3 spawnPos = new Vector3(rndNumber_x, 0.6f, 60);
        Instantiate(enemy, spawnPos, enemy.transform.rotation);
    }
    void SpawnObstacle4()
    {
        float rndNumber_x = Random.Range(-5, 5);
        Vector3 spawnPos = new Vector3(rndNumber_x, 0.6f, 65);
        Instantiate(enemy, spawnPos, enemy.transform.rotation);
    }
    void SpawnObstacle5()
    {
        float rndNumber_x = Random.Range(-5, 5);
        Vector3 spawnPos = new Vector3(rndNumber_x, 0.6f, 70);
        Instantiate(enemy, spawnPos, enemy.transform.rotation);
    }
    void SpawnObstacle6()
    {
        float rndNumber_x = Random.Range(-5, 5);
        Vector3 spawnPos = new Vector3(rndNumber_x, 0.6f, 75);
        Instantiate(enemy, spawnPos, enemy.transform.rotation);
    }
    void SpawnObstacle7()
    {
        int randumEnemy = Random.Range(0, 3);
        float rndNumber_x = Random.Range(-5, 5);
        Vector3 spawnPos = new Vector3(rndNumber_x, 0.6f, 80);
        Instantiate(enemy2[randumEnemy], spawnPos, enemy.transform.rotation);
    }
}