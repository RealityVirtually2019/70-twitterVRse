using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Twity; 

public class PostATweet : MonoBehaviour {

  public string post_content = "hi hi hi"; 

  public void start () {
    Debug.Log("click click click"); 
    Twity.Oauth.consumerKey       = "sjbkyhDmiRzqR4yD176q3M9yK";
    Twity.Oauth.consumerSecret    = "igeQG0t96EiCbrb2c1b7mUR7vIjuWXowoumGf5cbCY25BXUt0Z";
    Twity.Oauth.accessToken       = "3222732536-u7fpRbYdExxeSIipflayJaPFrAu3lZfHSPTowO0";
    Twity.Oauth.accessTokenSecret = "zP18sFkSGTadcvpCSW6v9lLsqll4FyOzg3r805UX3oQWI";
    Twet();
  }

   public void update(){
       if (Input.GetKeyDown("space")){
           Debug.Log("crycrycry"); 
           this.Twet();
       }
   }
  /*  public void PostTweet()
  {
    Debug.Log("tweet tweet"); 
    StartCoroutine(Twity.Client.GetOauth2BearerToken(Callback));
  }

  void Callback(bool success) {
    if (!success) {
        Debug.Log("no login"); 
    }
    Debug.Log(Twity.Oauth.bearerToken);
    // you write some request with application-only authentication
    Debug.Log("success!"); 
    this.Twet();
  } */

   public void Twet() {
        Debug.Log("hi hi hi"); 
        Dictionary<string, string> parameters = new Dictionary<string, string>();
        parameters ["status"] = post_content;
        StartCoroutine (Twity.Client.Post ("statuses/update", parameters, TweetCallback));
        Debug.Log("success"); 
    }

    void TweetCallback(bool success, string response) {
        if (success) {
            Debug.Log(response);
            //Tweet tweet = JsonUtility.FromJson<Tweet> (response);
        } else {
            Debug.Log (response);
        }
    }
}