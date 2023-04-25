using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public GameManager gameManager;

    public float minHeight = -1.5f;
    public float maxHeight = 1.5f;

    float startTime;
    public float timeSpawn = 1f;
    //public List<float> listTimeSpawn = new List<float>();
    //int currentSpawnIndex;
  /*  private void Start()
    {
        startTime = Time.time;
    }*/
    private void Update()
    {
        Spawn();
        /*if (listTimeSpawn.Count > 0 && currentSpawnIndex < listTimeSpawn.Count)
        {
            if (Time.time - startTime > listTimeSpawn[currentSpawnIndex])
            {
                GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
                pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
                currentSpawnIndex = currentSpawnIndex + 1;
            }
        }*/
    }

    private void Spawn()
    {
        if (Time.time > startTime)
        {
            startTime = Time.time + timeSpawn;
            GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
            pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        }
        else
        {
            Debug.Log("Can Spawn any pipes");
        }

        if (gameManager.score > 20)
        {
            Debug.Log("tăng tốc lên 1.7f");
            timeSpawn = 1.7f;
        }

        if (gameManager.score > 40)
        {
            Debug.Log("tăng tốc lên 1.5f");
            timeSpawn = 1.5f;
        }

        if (gameManager.score > 60)
        {
            Debug.Log("tăng tốc lên 1.3f");
            timeSpawn = 1.3f;
        }

        if (gameManager.score > 80)
        {
            Debug.Log("tăng tốc lên 1f");
            timeSpawn = 1f;
        }

        if (gameManager.score > 100)
        {
            Debug.Log("tăng tốc lên 0.7f");
            timeSpawn = 0.7f;
        }
    }
   
}
