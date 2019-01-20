using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Loads Sample Scenes
public class StartTweetMenu : MonoBehaviour
{
    public OVROverlay overlay;
    public OVROverlay text;
    public OVRCameraRig vrRig;

    void Start()
    {
        //Those text would be replaced by rest api data
        //we have the trend retrieving api working but since we cannot to tts we decide to hard code it
        DebugUIBuilder.instance.AddLabel("TwitterVRse - Today's Trends");
        DebugUIBuilder.instance.AddLabel("Press Button to Proceed");
        DebugUIBuilder.instance.AddLabel("1. #BewaretheFuries");
        DebugUIBuilder.instance.AddLabel("2. #Championship_Game");
        DebugUIBuilder.instance.AddLabel("3. #fedspeech");
        DebugUIBuilder.instance.AddLabel("4. #MA_Snow");
        DebugUIBuilder.instance.AddLabel("5. #SundayMorning");
        DebugUIBuilder.instance.AddButton("Continue", LoadBirdScene);
        DebugUIBuilder.instance.Show();
    }

    // Can't guarantee build order won't change, so use strings for loading
    void LoadScene(string sceneName)
    {
        DebugUIBuilder.instance.Hide();
        StartCoroutine(ShowOverlayAndLoad(sceneName));
    }

    IEnumerator ShowOverlayAndLoad(string sceneName)
    {
        text.transform.position = vrRig.centerEyeAnchor.position + Vector3.ProjectOnPlane(vrRig.centerEyeAnchor.forward, Vector3.up).normalized * 3f;
        overlay.enabled = true;
        text.enabled = true;
        // Waiting to prevent "pop" to new scene
        yield return new WaitForSeconds(1f);
        // Load Scene and wait til complet
       
        AsyncOperation asyncLoad = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        yield return null;
    }

    #region Scene Load Callbacks
    void LoadBirdScene()
    {
        LoadScene("BirdEnvironment");
    }
    #endregion
}
