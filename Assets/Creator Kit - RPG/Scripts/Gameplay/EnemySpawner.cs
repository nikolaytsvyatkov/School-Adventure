using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;

    private GameObject newEnemy1, newEnemy2, newEnemy3, newEnemy4, newEnemy5, newEnemy6, newEnemy7, 
        newEnemy8, newEnemy9, newEnemy10, newEnemy11;
    private SpriteRenderer rend1, rend2, rend3, rend4, rend5, rend6, rend7, rend8, rend9, rend10, rend11;
    private int randomSpawnZone;
    private float randomXposition, randomYposition;
    private Vector3 spawnPosition1, spawnPosition2, spawnPosition3, spawnPosition4, spawnPosition5, spawnPosition6, 
        spawnPosition7, spawnPosition8, spawnPosition9, spawnPosition10, spawnPosition11;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNewEnemy", 0f, 0f);
    }

    private void SpawnNewEnemy()
    {
        spawnPosition1 = new Vector3(-5.4f, -2.9f, 0f);
        spawnPosition2 = new Vector3(-1.5f, -0.8f, 0f);
        spawnPosition3 = new Vector3(7.6f, 4.3f, 0f);
        spawnPosition4 = new Vector3(12.4f, 7.4f, 0f);
        spawnPosition5 = new Vector3(14.6f, 7.4f, 0f);
        spawnPosition6 = new Vector3(17.4f, 0.8f, 0f);
        spawnPosition7 = new Vector3(19.8f, 0.8f, 0f);
        spawnPosition8 = new Vector3(24f, 5.9f, 0f);
        spawnPosition9 = new Vector3(26f, 6f, 0f);
        spawnPosition10 = new Vector3(27f, 0.6f, 0f);
        spawnPosition11 = new Vector3(28f, 0.4f, 0f);
        newEnemy1 = Instantiate(enemy, spawnPosition1, Quaternion.identity);
        newEnemy2 = Instantiate(enemy, spawnPosition2, Quaternion.identity);
        newEnemy3 = Instantiate(enemy, spawnPosition3, Quaternion.identity);
        newEnemy4 = Instantiate(enemy, spawnPosition4, Quaternion.identity);
        newEnemy5 = Instantiate(enemy, spawnPosition5, Quaternion.identity);
        newEnemy6 = Instantiate(enemy, spawnPosition6, Quaternion.identity);
        newEnemy7 = Instantiate(enemy, spawnPosition7, Quaternion.identity);
        newEnemy8 = Instantiate(enemy, spawnPosition8, Quaternion.identity);
        newEnemy9 = Instantiate(enemy, spawnPosition9, Quaternion.identity);
        newEnemy10 = Instantiate(enemy, spawnPosition10, Quaternion.identity);
        newEnemy11 = Instantiate(enemy, spawnPosition11, Quaternion.identity);
        rend1 = newEnemy1.GetComponent<SpriteRenderer>();
        rend1.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2), 1f);
        rend2 = newEnemy2.GetComponent<SpriteRenderer>();
        rend2.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2), 1f);
        rend3 = newEnemy3.GetComponent<SpriteRenderer>();
        rend3.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2), 1f);
        rend4 = newEnemy4.GetComponent<SpriteRenderer>();
        rend4.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2), 1f);
        rend5 = newEnemy5.GetComponent<SpriteRenderer>();
        rend5.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2), 1f);
        rend6 = newEnemy6.GetComponent<SpriteRenderer>();
        rend6.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2), 1f);
        rend7 = newEnemy7.GetComponent<SpriteRenderer>();
        rend7.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2), 1f);
        rend8 = newEnemy8.GetComponent<SpriteRenderer>();
        rend8.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2), 1f);
        rend9 = newEnemy9.GetComponent<SpriteRenderer>();
        rend9.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2), 1f);
        rend10 = newEnemy10.GetComponent<SpriteRenderer>();
        rend10.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2), 1f);
        rend11 = newEnemy11.GetComponent<SpriteRenderer>();
        rend11.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2), 1f);

    }
}
