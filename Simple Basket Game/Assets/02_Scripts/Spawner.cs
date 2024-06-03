using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject apple, bomb;
    float bombPercent;
    float spawnInterval, currentTime;
    // Start is called before the first frame update
    void Start()
    {
        bombPercent = 0.3f;

        spawnInterval = 0.5f;
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime >= spawnInterval)
        {
            Vector3 spawnPos = new Vector3(Mathf.RoundToInt(Random.Range(-1.5f, 1.5f)), transform.position.y, Mathf.RoundToInt(Random.Range(-1.5f, 1.5f)));
            currentTime = 0;
            if(Random.Range(0f, 1f) > bombPercent)
            {
                Instantiate(apple, spawnPos, transform.rotation);
            }
            else
            {
                Instantiate(bomb, spawnPos, transform.rotation);
            }
        }

        currentTime += Time.deltaTime;
    }


}
