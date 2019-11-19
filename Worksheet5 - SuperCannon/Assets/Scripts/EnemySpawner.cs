using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{


    // [SerializeField] GameObject enemyprefab;

    [SerializeField] List<GameObject> enemies;

    [SerializeField] float spawntime = 1f;

    int pickenemy = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
       
    }


    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            pickenemy = Random.Range(0, enemies.Count);
           

            Vector3 enemyPos = new Vector3(Random.Range(GameData.XMin, GameData.XMax),GameData.YMax,0f);
            Instantiate(enemies[pickenemy]   , enemyPos, Quaternion.identity);
            yield return new WaitForSeconds(spawntime);
        }

    }

}
