using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] fruits;
    public GameObject player;
    public GameObject gameoverText;
    public GameObject restartButton;
    public bool isGameover;

    private Vector3 spawnPos;
    private float xyLimit = 9.5f;
    private float startDelay = 2;
    private float repeatRate = 2;

    void Start()
    {
        InvokeRepeating("SpawnFruits", startDelay, repeatRate);
    }

    void SpawnFruits()
    {
        if (player != null)
        {
            int randomFruit = Random.Range(0, fruits.Length);
            float randomPosX = Random.Range(-xyLimit, xyLimit);
            float randomPosZ = Random.Range(-xyLimit, xyLimit);

            spawnPos = new Vector3(randomPosX, 0.5f, randomPosZ);

            Instantiate(fruits[randomFruit], spawnPos, fruits[randomFruit].transform.rotation);
        }
        else
        {
            gameoverText.SetActive(true);
        }
    }

    public void Restart()
    {
        isGameover = true;
        SceneManager.LoadScene(0);
    }
}
