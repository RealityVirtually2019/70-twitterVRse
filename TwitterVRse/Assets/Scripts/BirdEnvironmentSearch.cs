using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// C# example.

public class BirdEnvironmentSearch : MonoBehaviour
{


    //public GameObject[] selectedBird = null;

    void Update()
    {
        // Bit shift the index of the layer (8) to get a bit mask
        //int layerMask = 1 << 8;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        //layerMask = ~layerMask;
        //RaycastHit hit;
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
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch) >= 0.5)
        {
            Debug.Log("hit");
            SceneManager.LoadScene(sceneName: "BirdTalk");
        }
    }
    

}