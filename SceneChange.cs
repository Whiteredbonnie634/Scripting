using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    public string sceneName;
    private void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(sceneName);
    }
}
