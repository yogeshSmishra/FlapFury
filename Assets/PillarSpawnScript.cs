using UnityEngine;

public class PillarSpawnScript : MonoBehaviour
{
    public GameObject pillar;
    public float spawnRate = 2; // Time in seconds between spawns
    private float timer = 0;
    public float spawnHeight = 3; // Height at which the pillar will be spawned
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPillar();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPillar();
            timer = 0;
        }
    }

    void SpawnPillar()
    {
        float lowestPoint = transform.position.y - spawnHeight;
        float highestPoint = transform.position.y + spawnHeight;
        Instantiate(pillar, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0),transform.rotation);

    }
}
