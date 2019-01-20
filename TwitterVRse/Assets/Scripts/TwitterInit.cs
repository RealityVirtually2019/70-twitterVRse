using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Twity; 

public class TwitterInit : MonoBehaviour
{
    void Awake () 
    {
        Debug.Log("click click click"); 
        Twity.Oauth.consumerKey       = "sjbkyhDmiRzqR4yD176q3M9yK";
        Twity.Oauth.consumerSecret    = "igeQG0t96EiCbrb2c1b7mUR7vIjuWXowoumGf5cbCY25BXUt0Z";
        Twity.Oauth.accessToken       = "3222732536-u7fpRbYdExxeSIipflayJaPFrAu3lZfHSPTowO0";
        Twity.Oauth.accessTokenSecret = "zP18sFkSGTadcvpCSW6v9lLsqll4FyOzg3r805UX3oQWI";

    }
}
