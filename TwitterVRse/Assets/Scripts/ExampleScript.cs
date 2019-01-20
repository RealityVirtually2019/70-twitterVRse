using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.Windows.Speech;


public class ExampleScript : MonoBehaviour {
    public GameObject prefabBird;
	// Use this for initialization
	void Start () {
        //Bird Group 1

        var trend1Birds = new List<GameObject>();
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
        var bird11= Instantiate(prefabBird);
        var bird12 = Instantiate(prefabBird);
        //trend 1
        var bird13= Instantiate(prefabBird);
        var bird14= Instantiate(prefabBird);
        //trend 1
        var bird15 = Instantiate(prefabBird);
        trend1Birds.Add(bird1);
        trend1Birds.Add(bird2);
        trend1Birds.Add(bird3);
        trend1Birds.Add(bird4);
        trend1Birds.Add(bird5);
        bird1.transform.position = new Vector3(1, 1, 1);
        bird2.transform.position = new Vector3(4, 1, 1);
        bird3.transform.position = new Vector3(7, 1, 1);
        bird4.transform.position = new Vector3(10, 1, 1);
        bird5.transform.position = new Vector3(13, 1, 1);

        StartDictation();
    }
    
    //Speech Recogntion using Cortana
    //To trigger
    [SerializeField]
    private TextMesh m_Hypotheses;

    [SerializeField]
    private TextMesh m_Recognitions;

    private DictationRecognizer m_DictationRecognizer;

    void StartDictation()
    {
        m_DictationRecognizer = new DictationRecognizer();

        m_DictationRecognizer.DictationResult += (text, confidence) =>
        {
            Debug.LogFormat("Dictation result: {0}", text);
            m_Recognitions.text += text + "\n";
        };

        m_DictationRecognizer.DictationHypothesis += (text) =>
        {
            Debug.LogFormat("Dictation hypothesis: {0}", text);
            m_Hypotheses.text += text;
        };

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
    // Update is called once per frame
    void Update () {
		
	}
}
