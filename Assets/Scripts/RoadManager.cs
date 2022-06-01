using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public GameObject[] roadPrefabs;
    private Transform playerTransform;
    //Start path behind the player by spawnZ value
    private float spawnZ = 10f;
    //spawn road based on roadLength
    private float roadLength = 58.5f;
    //Create as many paths as amnRoadOnScreen
    private int amnRoadOnScreen = 7;
    private List<GameObject> activeRoads;
    //Wait for the safeZone value before destroying the path
    private float safeZone = 50f;
    //Always create prefab with lastPrefabIndex first
    private int lastPrefabIndex = 0;

    private void Start() 
    {
        activeRoads = new List<GameObject>();
        //Get the player's transform
       playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

       for (int i = 0; i < amnRoadOnScreen; i++)
       {
           if (i < 2)
           {
               SpawnRoad(0);
           }
           else
           {
               SpawnRoad();
           }
           
       }    
    }

    private void Update() 
    {
       if (playerTransform.position.z - safeZone > (spawnZ - amnRoadOnScreen * roadLength))
       {
           SpawnRoad();
           DeleteRoad();
       }    
    }

    private void SpawnRoad(int prefanIndex = -1)
    {
        GameObject go;
        if (prefanIndex == -1)
        {
            go = Instantiate(roadPrefabs [RandomPrefabIndex()]) as GameObject;
        }
        else
        {
            go = Instantiate(roadPrefabs [prefanIndex]) as GameObject;
        }
        
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += roadLength;
        activeRoads.Add(go);
    }

    private void DeleteRoad()
    {
        Destroy(activeRoads[0]);
        activeRoads.RemoveAt(0);
    }

    private int RandomPrefabIndex()
    {
        if (roadPrefabs.Length <= -1)
        {
            return 0;
        }
        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, roadPrefabs.Length);
        }
        lastPrefabIndex = randomIndex;
        return randomIndex;
    }
}
