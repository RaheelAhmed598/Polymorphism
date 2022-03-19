using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fruit : MonoBehaviour
{
    private static int score = 0;
    private TextMeshProUGUI scoreText;
    private FruitSpawner spawnManager;

    void Start()
    {
        spawnManager = GameObject.Find("SpawnManager").GetComponent<FruitSpawner>();
        scoreText = GameObject.Find("Score Text").GetComponent<TextMeshProUGUI>();
        if (spawnManager.isGameover == true)
        {
            score = 0;
            spawnManager.isGameover = false;
        }
    }

    public virtual void Location(Vector3 location)
    {

    }

    public virtual void ScoreCount(int pointScore)
    {
            
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
