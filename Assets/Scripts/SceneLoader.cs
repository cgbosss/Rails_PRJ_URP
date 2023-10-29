using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public Button nextSceneButton;
    public string nextSceneName;

    private void Start()
    {
        // Ensure you have assigned the Button component in the Inspector.
        if (nextSceneButton != null)
        {
            // Add a click event listener to the button.
            nextSceneButton.onClick.AddListener(OpenNextScene);
        }
        else
        {
            Debug.LogWarning("NextSceneButton script: Please assign a Button in the Inspector.");
        }
    }

    private void OpenNextScene()
    {
        // Load the next scene by name from the build settings.
        SceneManager.LoadScene(nextSceneName);
    }

    //Generic Function to load Scene Name by String or List
    public void LoadSceneName(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

}
