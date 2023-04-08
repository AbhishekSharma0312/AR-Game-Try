using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficManager : MonoBehaviour
{
    public static TrafficManager Instance; 

    public GameObject[] lane_Object;
    public Transform[] lane_spawnPoint;
    public Transform[] lane_deSpawnPoint;
    public GameObject[] vehicles;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    public void PlayGameButtonPressed()
    {
        StartCoroutine(SpawnRandomVehicleOnLane1());
        StartCoroutine(SpawnRandomVehicleOnLane2());
        StartCoroutine(SpawnRandomVehicleOnLane3());
        StartCoroutine(SpawnRandomVehicleOnLane4());
        StartCoroutine(SpawnRandomVehicleOnLane5());
    }

    IEnumerator SpawnRandomVehicleOnLane1()
    {
        int randomProb = Random.Range(0,10);
        int randomVehicleIndex = 0;
        if(randomProb >= 8)
        {
            randomVehicleIndex = Random.Range(5,7);
        }
        else
        {
            randomVehicleIndex = Random.Range(0,5);
        }
        float randomWaitTime = Random.Range(3f, 5f);
        yield return new WaitForSecondsRealtime(randomWaitTime);

        var newVehicle = Instantiate(vehicles[randomVehicleIndex], lane_Object[0].transform);
        newVehicle.transform.position = new Vector3(newVehicle.transform.position.x, newVehicle.transform.position.y, lane_spawnPoint[0].position.z);
        newVehicle.GetComponent<VehicleMovement>().SetUpAndMoveVehicle(lane_spawnPoint[0], lane_deSpawnPoint[0]);

        StartCoroutine(SpawnRandomVehicleOnLane1());
    }

    IEnumerator SpawnRandomVehicleOnLane2()
    {
        int randomProb = Random.Range(0,10);
        int randomVehicleIndex = 0;
        if(randomProb >= 8)
        {
            randomVehicleIndex = Random.Range(5,7);
        }
        else
        {
            randomVehicleIndex = Random.Range(0,5);
        }
        float randomWaitTime = Random.Range(3f, 5f);
        yield return new WaitForSecondsRealtime(randomWaitTime);

        var newVehicle = Instantiate(vehicles[randomVehicleIndex], lane_Object[1].transform);
        newVehicle.transform.position = new Vector3(newVehicle.transform.position.x, newVehicle.transform.position.y, lane_spawnPoint[1].position.z);
        newVehicle.GetComponent<VehicleMovement>().SetUpAndMoveVehicle(lane_spawnPoint[1], lane_deSpawnPoint[1]);

        StartCoroutine(SpawnRandomVehicleOnLane2());
    }

    IEnumerator SpawnRandomVehicleOnLane3()
    {
        int randomProb = Random.Range(0,10);
        int randomVehicleIndex = 0;
        if(randomProb >= 8)
        {
            randomVehicleIndex = Random.Range(5,7);
        }
        else
        {
            randomVehicleIndex = Random.Range(0,5);
        }
        float randomWaitTime = Random.Range(3f, 5f);
        yield return new WaitForSecondsRealtime(randomWaitTime);

        var newVehicle = Instantiate(vehicles[randomVehicleIndex], lane_Object[2].transform);
        newVehicle.transform.position = new Vector3(newVehicle.transform.position.x, newVehicle.transform.position.y, lane_spawnPoint[2].position.z);
        newVehicle.GetComponent<VehicleMovement>().SetUpAndMoveVehicle(lane_spawnPoint[2], lane_deSpawnPoint[2]);

        
        StartCoroutine(SpawnRandomVehicleOnLane3());
    }

    IEnumerator SpawnRandomVehicleOnLane4()
    {
        int randomProb = Random.Range(0,10);
        int randomVehicleIndex = 0;
        if(randomProb >= 8)
        {
            randomVehicleIndex = Random.Range(5,7);
        }
        else
        {
            randomVehicleIndex = Random.Range(0,5);
        }
        float randomWaitTime = Random.Range(3f, 5f);
        yield return new WaitForSecondsRealtime(randomWaitTime);

        var newVehicle = Instantiate(vehicles[randomVehicleIndex], lane_Object[3].transform);
        newVehicle.transform.position = new Vector3(newVehicle.transform.position.x, newVehicle.transform.position.y, lane_spawnPoint[3].position.z);
        newVehicle.GetComponent<VehicleMovement>().SetUpAndMoveVehicle(lane_spawnPoint[3], lane_deSpawnPoint[3]);

        StartCoroutine(SpawnRandomVehicleOnLane4());
    }

    IEnumerator SpawnRandomVehicleOnLane5()
    {
        int randomProb = Random.Range(0,10);
        int randomVehicleIndex = 0;
        if(randomProb >= 8)
        {
            randomVehicleIndex = Random.Range(5,7);
        }
        else
        {
            randomVehicleIndex = Random.Range(0,5);
        }
        float randomWaitTime = Random.Range(3f, 5f);
        yield return new WaitForSecondsRealtime(randomWaitTime);

        var newVehicle = Instantiate(vehicles[randomVehicleIndex], lane_Object[4].transform);
        newVehicle.transform.position = new Vector3(newVehicle.transform.position.x, newVehicle.transform.position.y, lane_spawnPoint[4].position.z);
        newVehicle.GetComponent<VehicleMovement>().SetUpAndMoveVehicle(lane_spawnPoint[4], lane_deSpawnPoint[4]);

        StartCoroutine(SpawnRandomVehicleOnLane5());
    }

}