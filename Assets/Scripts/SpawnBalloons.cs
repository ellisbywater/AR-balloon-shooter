using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalloons : MonoBehaviour
{
    public Transform[] spawnPoints;

    public GameObject[] balloons;

    public int liveBalloons;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(4);
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Instantiate(balloons[i], spawnPoints[i].position, Quaternion.identity);
            liveBalloons++;
        }
        
        StartCoroutine(StartSpawning());
    }
    
}
