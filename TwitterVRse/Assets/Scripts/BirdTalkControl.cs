using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class BirdTalkControl : MonoBehaviour {


 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch) >= 0.5)
        {
            Debug.Log("hit");
        
            SceneManager.LoadScene(sceneName: "BirdTweetTest");
        }
    }
}
