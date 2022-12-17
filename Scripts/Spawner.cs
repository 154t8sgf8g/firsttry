using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    public float TimeSpawn;
    [SerializeField] Vector2 range;
    [SerializeField] GameObject item;

    void Start()
    {
        StartCoroutine(Spawn());

    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Vector2 pos = spawnPos.position + new Vector3(Random.Range(-range.x, range.x), 0);
        Instantiate(item, pos, Quaternion.identity);
        Repeat();
    }
    
    void Repeat()
    {
        StartCoroutine(Spawn());
    }
}
