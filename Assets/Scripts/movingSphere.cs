using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingSphere : MonoBehaviour
{
    public GameObject sphere;
    public int numberOfSpheres;
    List<GameObject> spheresList = new List<GameObject>();
    List<Vector3> randomSpeedArray = new List<Vector3>();

    void Start()
    {
        for (int i = 0; i < numberOfSpheres; i++)
        {
            GameObject sphereItem = Instantiate(sphere);
            float sphereScale = Random.Range(0.1f, 1f);
            sphereItem.GetComponent<Transform>().localScale = new Vector3(sphereScale, sphereScale, sphereScale);
            spheresList.Add(sphereItem);
        }
        sphere.SetActive(false);

        for (int i = 0; i < spheresList.Count; i++)
        {
            randomSpeedArray.Add(new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f)));
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < spheresList.Count; i++)
        {
            sphereMovement(spheresList[i], i);
        }
    }


    void sphereMovement(GameObject sphere, int i)
    {
        sphere.GetComponent<Transform>().Translate(randomSpeedArray[i].x * Time.deltaTime, randomSpeedArray[i].y * Time.deltaTime, randomSpeedArray[i].z * Time.deltaTime);

        if (sphere.GetComponent<Transform>().position.x > 10 || sphere.GetComponent<Transform>().position.x < -10)
        {
            randomSpeedArray[i] = new Vector3(-randomSpeedArray[i].x, randomSpeedArray[i].y, randomSpeedArray[i].z);
        }
        if (sphere.GetComponent<Transform>().position.y > 10 || sphere.GetComponent<Transform>().position.y < -10)
        {
            randomSpeedArray[i] = new Vector3(randomSpeedArray[i].x, -randomSpeedArray[i].y, randomSpeedArray[i].z);
        }
        if (sphere.GetComponent<Transform>().position.z > 10 || sphere.GetComponent<Transform>().position.z < -10)
        {
            randomSpeedArray[i] = new Vector3(randomSpeedArray[i].x, randomSpeedArray[i].y,- randomSpeedArray[i].z);
        }
    }
}
