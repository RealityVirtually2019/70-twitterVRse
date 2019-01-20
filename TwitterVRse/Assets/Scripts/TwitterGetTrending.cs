using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Twity.DataModels.Responses;
using Twity.DataModels.Responses;

public class TwitterGetTrending : MonoBehaviour{

    public List<string> trending = new List<string>();  

    void Start() {
    Dictionary<string, string> parameters = new Dictionary<string, string>();
    parameters ["id"] = "1";
    StartCoroutine (Twity.Client.Get ("trends/place", parameters, Callback));
    }

    void Callback(bool success, string response) {
        if (success) {
            Debug.Log(response); 
            TrendsPlaceResponse big_json = JsonUtility.FromJson<TrendsPlaceResponse>(response); 
            for (int i = 0; i < 5; i++) {
                trending.Add(big_json.items[0].trends[i].name);
            }
            foreach(string trend in trending)
            {
                Debug.Log(trend);
            }
            
            } else {
                Debug.Log (response);
            }
    }
}