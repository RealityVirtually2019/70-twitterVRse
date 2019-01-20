using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdPrefabControl : MonoBehaviour
{

    public GameObject prefabBird;
    // Use this for initialization
    void Start()
    {
        //Bird Group 1

        var trend1Birds = new List<GameObject>();
        var trend2Birds = new List<GameObject>();
        var trend3Birds = new List<GameObject>();
        var trend4Birds = new List<GameObject>();
        var trend5Birds = new List<GameObject>();
        // Note that there is a sample bird
        // Intiazize the object and add it to the collection
        //the code might not be pretty but since the locations are very precise to each bird, we did it one by one
        //trend 1
        var bird1 = Instantiate(prefabBird);
        var bird2 = Instantiate(prefabBird);
        var bird3 = Instantiate(prefabBird);
        var bird4 = Instantiate(prefabBird);
        var bird5 = Instantiate(prefabBird);
        //trend 2
        var bird6 = Instantiate(prefabBird);
        var bird7 = Instantiate(prefabBird);
        var bird8 = Instantiate(prefabBird);
        var bird9 = Instantiate(prefabBird);
        //trend 3
        var bird10 = Instantiate(prefabBird);
        var bird11 = Instantiate(prefabBird);
        var bird12 = Instantiate(prefabBird);
        //trend 1
        var bird13 = Instantiate(prefabBird);
        var bird14 = Instantiate(prefabBird);
        //trend 1
        var bird15 = Instantiate(prefabBird);
        trend1Birds.Add(bird1);
        trend1Birds.Add(bird2);
        trend1Birds.Add(bird3);
        trend1Birds.Add(bird4);
        trend1Birds.Add(bird5);
        trend2Birds.Add(bird6);
        trend2Birds.Add(bird7);
        trend2Birds.Add(bird8);
        trend2Birds.Add(bird9);
        trend3Birds.Add(bird10);
        trend3Birds.Add(bird11);
        trend3Birds.Add(bird12);
        trend4Birds.Add(bird13);
        trend4Birds.Add(bird14);
        trend5Birds.Add(bird15);

        foreach (GameObject bird in trend1Birds)
        {
            bird.transform.localScale = new Vector3(0.29288f, 0.29288f, 0.29288f);
        }
        foreach (GameObject bird in trend2Birds)
        {
            bird.transform.localScale = new Vector3(0.29288f, 0.29288f, 0.29288f);
        }
        foreach (GameObject bird in trend3Birds)
        {
            bird.transform.localScale = new Vector3(0.29288f, 0.29288f, 0.29288f);
        }
        foreach (GameObject bird in trend4Birds)
        {
            bird.transform.localScale = new Vector3(0.29288f, 0.29288f, 0.29288f);
        }
        foreach (GameObject bird in trend5Birds)
        {
            bird.transform.localScale = new Vector3(0.29288f, 0.29288f, 0.29288f);
        }



        bird1.transform.position = new Vector3(304.507f, 8.76f, 140.116f);
        Quaternion bird1Rotation = Quaternion.Euler(1.544f, -30.45f, 23.463f);
        bird1.transform.rotation = bird1Rotation;
        
        bird2.transform.position = new Vector3(303.41f, 8.69f, 135.939f);
        Quaternion bird2Rotation = Quaternion.Euler(1.544f, -100.065f, 23.463f);
        bird2.transform.rotation = bird2Rotation;

        bird3.transform.position = new Vector3(298.8185f, 8.70f, 132.88f);
        Quaternion bird3Rotation = Quaternion.Euler(3.561f, -202.993f, 28.104f);
        bird3.transform.rotation = bird3Rotation;

        bird4.transform.position = new Vector3(300.6756f, 21.5522f, 136.1568f);
        Quaternion bird4Rotation = Quaternion.Euler(-5.273f, -204.4f, 31.857f);
        bird4.transform.rotation = bird4Rotation;

        bird5.transform.position = new Vector3(303.5669f, 21.55f, 139.8469f);
        Quaternion bird5Rotation = Quaternion.Euler(-5.273f, -143.524f, 31.858f);
        bird5.transform.rotation = bird5Rotation;

        bird6.transform.position = new Vector3(276.55f, 11.31f, 128.44f);
        Quaternion bird6Rotation = Quaternion.Euler(-5.273f, -58.896f, 31.858f);
        bird6.transform.rotation = bird6Rotation;

        bird7.transform.position = new Vector3(299.8f, 8.69f, 138.92f);
        Quaternion bird7Rotation = Quaternion.Euler(-1.563f, -13.772f, 16.138f);
        bird7.transform.rotation = bird7Rotation;

        bird8.transform.position = new Vector3(274.0538f, 5.91f, 98.82f);
        Quaternion bird8Rotation = Quaternion.Euler(2.451f, 100.881f, 18.317f);
        bird8.transform.rotation = bird8Rotation;

        bird9.transform.position = new Vector3(278.182f, 7.173f, 98.86589f);
        Quaternion bird9Rotation = Quaternion.Euler(2.451f, 164.449f, 18.317f);
        bird9.transform.rotation = bird9Rotation;

        bird10.transform.position = new Vector3(286.119f, 10.74f, 107.1731f);
        Quaternion bird10Rotation = Quaternion.Euler(2.451f, 57.936f, 18.317f);
        bird10.transform.rotation = bird10Rotation;

        bird11.transform.position = new Vector3(286.3773f, 8.8f, 107.0984f);
        Quaternion bird11Rotation = Quaternion.Euler(2.451f, 116.313f, 18.317f);
        bird11.transform.rotation = bird11Rotation;

        bird12.transform.position = new Vector3(282.9201f, 12.06f, 107.2063f);
        Quaternion bird12Rotation = Quaternion.Euler(2.451f, 142.884f, 18.317f);
        bird12.transform.rotation = bird12Rotation;

        bird13.transform.position = new Vector3(277.76f, 2.28f, 104.5306f);
        Quaternion bird13Rotation = Quaternion.Euler(12.423f, 116.246f, 9.406f);
        bird13.transform.rotation = bird13Rotation;

        bird14.transform.position = new Vector3(275.1467f, 2.280981f, 104.4089f);
        Quaternion bird14Rotation = Quaternion.Euler(4.342f, 68.006f, 9.306001f);
        bird14.transform.rotation = bird14Rotation;

        bird15.transform.position = new Vector3(261.23f, 7.65257f, 98.62321f);
        Quaternion bird15Rotation = Quaternion.Euler(-1.6f, 101.036f, 39.008f);
        bird15.transform.rotation = bird15Rotation;


    }


}