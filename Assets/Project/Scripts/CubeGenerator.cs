using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject emptyCube;

    public float timer = 0.3f;
    float counter;

    void Start()
    {
        counter = timer;
    }

    void Update()
    {
        int randomPos = Random.Range(-12, 12);

        if (counter > 0)
        {
            counter -= Time.deltaTime;
        }
        else
        {
            Instantiate(emptyCube, new Vector3(0, 13, randomPos), Quaternion.identity);
            counter = timer;
        }

    }
}
