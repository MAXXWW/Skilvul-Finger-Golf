using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneLoader
{
    private static string sceneToLoad;
    public static string SceneToLoad { get => sceneToLoad; }

    // Load
    public static void Load(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Progress Load
    public static void ProgressLoad(string sceneName)
    {
        sceneToLoad = sceneName;
        SceneManager.LoadScene("LoadingProgress");
        // SceneLoader.ProgressLoad(sceneName);
    }

    // Reload Level
    public static void ReloadLevel()
    {
        var currentScene = SceneManager.GetActiveScene().name;
        ProgressLoad(currentScene);
        Debug.Log("berhasil reload scene");
    }

    // Load Next Level
    public static void LoadNextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            Debug.Log("You Win The Game");
        }
        else
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            int nextLevel = int.Parse(currentSceneName.Split("Level")[1]) + 1;
            string nextSceneName = "Level" + nextLevel;

            if (SceneUtility.GetBuildIndexByScenePath(nextSceneName) == -1)
            {
                Debug.LogError(nextSceneName + " does not exists");
                return;
            }

            ProgressLoad(nextSceneName);

            int getSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

            if (getSceneIndex > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", getSceneIndex);
            }
        }
    }
}
