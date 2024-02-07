using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public GameObject ballPrefab;
    public GameObject floor;
    public Transform spawnTransform;
    public Vector3 dontDoThisMethodPosition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPosition = spawnTransform.position;
            Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
            Debug.Log("Ball has been created");
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (floor.activeSelf)
            {
                floor.SetActive(false);
                Debug.Log("Floor is disabled");
            }
            else
            {
                floor.SetActive(true);
                Debug.Log("Floor is enabled");
            }
        }
    }
}
