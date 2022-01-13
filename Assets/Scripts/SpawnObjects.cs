using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] spawnableObject;
    public float time;


    private void Start()
    {
        StartCoroutine(SpawnOverTime());
    }

    private IEnumerator SpawnOverTime()
    {
        while (true)
        {
            Debug.Log("CorutineWorks");
            Instantiate(spawnableObject[Random.Range(0,11)], new Vector3(spawnPoints[Random.Range(0, 8)].transform.position.x, 80,90),transform.rotation);
            yield return new WaitForSeconds(time);
        }
       
    }

}