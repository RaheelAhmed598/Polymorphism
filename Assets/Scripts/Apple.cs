using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit
{
    private Vector3 myLocation;
    private int myScore = 5;

    void Awake()
    {
        myLocation = transform.position;
        StartCoroutine(Lifetime());
    }

    private void OnTriggerEnter(Collider other)
    {
        Location(myLocation);
        ScoreCount(myScore);
        Destroy(gameObject);
    }

    public override void Location(Vector3 location)
    {
        Debug.Log("Fruit spawned at: " + location);
    }

    public override void ScoreCount(int pointScore)
    {
        Debug.Log("Fruit Points: " + pointScore);
        AddScore(pointScore);
    }

    IEnumerator Lifetime()
    {
        yield return new WaitForSeconds(6);
        Destroy(gameObject);
    }
}
