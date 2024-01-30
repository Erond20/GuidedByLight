using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] EnemySpawnPoints;
    public Transform RandomPick;
    public GameObject Enemy;

    public bool RandomPickIsSelected;
    public bool EnemySpawned;
    private void Start()
    {
        RandomPickIsSelected = false;
        EnemySpawned = false;
    }
    private void Update()
    {
        StartCoroutine(SpawnEnemy());
        
       
    }

    public void PickRandomSpawnPoints()
    {
        if(!RandomPickIsSelected)
        {
        RandomPick = EnemySpawnPoints[Random.Range(0, EnemySpawnPoints.Length)];
            RandomPickIsSelected = true;
        }
        

    }
    IEnumerator SpawnEnemy()
    {
        if(RandomPickIsSelected && !EnemySpawned)
        {
            EnemySpawned = true;
        yield return new WaitForSeconds(2);
        Instantiate(Enemy, RandomPick.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2);
            // when you want to spawn next time 
            EnemySpawned = false;
        }
        else
        {
        PickRandomSpawnPoints();
        yield return new WaitForSeconds(2);
        RandomPickIsSelected = false;
        }


    }

}
