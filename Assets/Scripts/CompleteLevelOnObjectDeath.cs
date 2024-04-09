using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevelOnObjectDeath : MonoBehaviour
{
    public string sceneName;
    public GameObject objectToComplete;

    void Update()
    {
        if (objectToComplete.activeSelf == false)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
