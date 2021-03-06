using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AISpawner : MonoBehaviour
{
    public MoveTo AIPrefab;
    public Transform goal;
    public float interval = 2;

    public int spawnCount = 0;

    void Start()
    {
        StartCoroutine(SpawnAI());
    }

    IEnumerator SpawnAI() {
        spawnCount += 1;

        while(true) {
            while(spawnCount < 3) {
                yield return new WaitForSeconds(interval);
                MoveTo copy = Instantiate(AIPrefab, 
                                            this.transform.position, 
                                            this.transform.rotation);
                copy.goal = goal;
            }
        }
    }
}
