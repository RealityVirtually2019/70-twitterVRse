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


        bird1.transform.position = new Vector3(1, 1, 1);
        bird2.transform.position = new Vector3(4, 1, 1);
        bird3.transform.position = new Vector3(7, 1, 1);
        bird4.transform.position = new Vector3(10, 1, 1);
        bird5.transform.position = new Vector3(13, 1, 1);
        bird6.transform.position = new Vector3(13, 1, 1);
        bird7.transform.position = new Vector3(13, 1, 1);
        bird8.transform.position = new Vector3(13, 1, 1);
        bird9.transform.position = new Vector3(13, 1, 1);
        bird10.transform.position = new Vector3(13, 1, 1);
        bird11.transform.position = new Vector3(13, 1, 1);
        bird12.transform.position = new Vector3(13, 1, 1);
        bird13.transform.position = new Vector3(13, 1, 1);
        bird14.transform.position = new Vector3(13, 1, 1);
        bird15.transform.position = new Vector3(33, 1, 1);
    }


}