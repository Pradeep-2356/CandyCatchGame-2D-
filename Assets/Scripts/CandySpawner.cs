using UnityEngine;
using System.Collections;

public class CandySpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    float maxX;

    public float spawnInterval;
   public GameObject[] Candies;

   public static CandySpawner instance;

   private void Awake()
   {
    if(instance == null)
    {
        instance = this;
    }
   }
    void Start()
    {
        StartSpawningCandies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCandy()
    {
        int rand = Random.Range(0, Candies.Length);
        float randomX = Random.Range(-maxX,maxX);
        Vector3 randomPos = new Vector3(randomX, transform.position.y,transform.position.z);
         Instantiate(Candies[rand],randomPos, transform.rotation);
    }

    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(2f);
        while(true)
        {
            SpawnCandy();
            yield return new WaitForSeconds(spawnInterval);
        }
    }


    public void StartSpawningCandies()
    {
        StartCoroutine("SpawnCandies");
    }

    public void StopSpawningCandies()
    {
        StopCoroutine("SpawnCandies");
    }
}

