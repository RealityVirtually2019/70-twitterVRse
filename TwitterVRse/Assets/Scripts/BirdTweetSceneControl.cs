using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Twity;

// C# example.

public class BirdTweetSceneControl : MonoBehaviour
{


    public GameObject[] selectedTweetOptions = null;

    public string post_content = "hhi";


    void Start()
    {
        Twity.Oauth.consumerKey = "sjbkyhDmiRzqR4yD176q3M9yK";
        Twity.Oauth.consumerSecret = "igeQG0t96EiCbrb2c1b7mUR7vIjuWXowoumGf5cbCY25BXUt0Z";
        Twity.Oauth.accessToken = "3222732536-u7fpRbYdExxeSIipflayJaPFrAu3lZfHSPTowO0";
        Twity.Oauth.accessTokenSecret = "zP18sFkSGTadcvpCSW6v9lLsqll4FyOzg3r805UX3oQWI";
    }



    void Update()
    {
        // Bit shift the index of the layer (8) to get a bit mask
        //int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        //layerMask = ~layerMask;
        RaycastHit hit;
        /*Debug.Log(this.gameObject.transform.position);
        Debug.Log(this.gameObject.transform.forward);

        LineRenderer laser = new LineRenderer();
        laser.startColor = Color.yellow;
        laser.endColor = Color.yellow;
        laser.SetPosition(0, this.gameObject.transform.position);
        laser.startWidth = 1.0f;
        laser.endWidth = 1.0f;
        const string Contents = "../materials/wood";
        laser.material = new Material(Contents);

        laser.useWorldSpace = true;

        laser.SetPosition(1, this.gameObject.transform.position+ transform.TransformDirection(this.gameObject.transform.forward) * 1000);
        

        Debug.DrawRay(this.gameObject.transform.position, transform.TransformDirection(this.gameObject.transform.forward) * 1000, Color.yellow);
        */
        // Does the ray intersect any objects excluding the player layer
        //Debug.Log("hit");  

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
            //Debug.Log("Did Hit");
            //Debug.Log(hit);
            if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch) >= 0.5f)
            {
                Debug.Log("Confirm!!!!!");
                Debug.Log(hit.transform.tag);
                //if (null == null)
                //{
                Debug.Log("birds detected by tags");
                selectedTweetOptions = GameObject.FindGameObjectsWithTag(hit.transform.tag);
                Debug.Log(selectedTweetOptions);
                selectedTweetOptions[0].transform.Translate(1, 1, 1);
                Twet();

                //}
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.yellow);
            //Debug.Log("Did not Hit");
        }
    }


    void Twet()
    {
        Dictionary<string, string> parameters = new Dictionary<string, string>();
        parameters["status"] = post_content;
        StartCoroutine(Twity.Client.Post("statuses/update", parameters, TweetCallback));
        Debug.Log("success");
    }

    void TweetCallback(bool success, string response)
    {
        if (success)
        {
            Debug.Log(response);
            //Tweet tweet = JsonUtility.FromJson<Tweet> (response);
        }
        else
        {
            Debug.Log(response);
        }
    }

}