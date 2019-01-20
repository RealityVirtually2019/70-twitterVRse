using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Twity;
using UnityEngine.Windows.Speech;


// C# example.

public class BirdTweetSceneControl : MonoBehaviour
{


    public GameObject[] selectedTweetOptions = null;

    public string post_content;

    //Speech Recogntion using Cortana
    //To trigger
    //[SerializeField]
    //private TextMesh m_Hypotheses;

    [SerializeField]
    private TextMesh m_Recognitions;

    public DictationRecognizer m_DictationRecognizer;


    void Start()
    {
        Twity.Oauth.consumerKey = "sjbkyhDmiRzqR4yD176q3M9yK";
        Twity.Oauth.consumerSecret = "igeQG0t96EiCbrb2c1b7mUR7vIjuWXowoumGf5cbCY25BXUt0Z";
        Twity.Oauth.accessToken = "3222732536-u7fpRbYdExxeSIipflayJaPFrAu3lZfHSPTowO0";
        Twity.Oauth.accessTokenSecret = "zP18sFkSGTadcvpCSW6v9lLsqll4FyOzg3r805UX3oQWI";
    }


    void Update()
    {
        RaycastHit hit;
       
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
            //Debug.Log("Did Hit");
            //Debug.Log(hit);
            Debug.Log("Confirm hit");
            Debug.Log(hit.transform.tag);
            //if (null == null)
            //{
            Debug.Log("birds detected by tags");
            selectedTweetOptions = GameObject.FindGameObjectsWithTag(hit.transform.tag);
            Debug.Log(selectedTweetOptions);

            selectedTweetOptions[0].transform.localScale = new Vector3(1.5F, 1.5F, 1.5F);


            if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch) >= 0.5f)
            {
                selectedTweetOptions[0].transform.Translate(1, 1, 1);
                //Twet();
                StartDictation();
            }
            
            //EndDiction();
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.yellow);
            //Debug.Log("Did not Hit"); 
            selectedTweetOptions[0].transform.localScale = new Vector3(1.0F, 1.0F, 1.0F);

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

    void StartDictation()
    {
        m_DictationRecognizer = new DictationRecognizer();

        m_DictationRecognizer.DictationResult += (text, confidence) =>
        {
            Debug.LogFormat("Dictation result: {0}", text);
            m_Recognitions.text += text + "\n";
            Debug.Log("text length: " + m_Recognitions.text.Length);
            Debug.Log(OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch));

            if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch) <= 0.5f)
            {
                m_DictationRecognizer.Stop();
                Debug.Log("recognition stopped");
                post_content = m_Recognitions.text;
                Twet();
            }

        };

        /*m_DictationRecognizer.DictationHypothesis += (text) =>
        {
            Debug.LogFormat("Dictation hypothesis: {0}", text);
            m_Hypotheses.text += text;
        };*/


        m_DictationRecognizer.DictationComplete += (completionCause) =>
        {
            if (completionCause != DictationCompletionCause.Complete)
                Debug.LogErrorFormat("Dictation completed unsuccessfully: {0}.", completionCause);
        };

        m_DictationRecognizer.DictationError += (error, hresult) =>
        {
            Debug.LogErrorFormat("Dictation error: {0}; HResult = {1}.", error, hresult);
        };

        m_DictationRecognizer.Start();

    }

    //void EndDiction()
    //{
    //    m_DictationRecognizer.Stop();
    //}

}