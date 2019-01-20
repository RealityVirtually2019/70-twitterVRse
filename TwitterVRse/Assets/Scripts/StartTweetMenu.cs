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
        DebugUIBuilder.instance.AddLabel("TwitterVRse - Today's Trends");
        DebugUIBuilder.instance.AddLabel("1. #Shutdown");
        DebugUIBuilder.instance.AddLabel("2. #SaturdayMorning");
        DebugUIBuilder.instance.AddLabel("3. #SnowstormBooks");
        DebugUIBuilder.instance.AddLabel("4. #SaturdayThoughts");
        DebugUIBuilder.instance.AddLabel("5. #WomensMarch");
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
        LoadScene("BirdScene");
    }
    #endregion
}
