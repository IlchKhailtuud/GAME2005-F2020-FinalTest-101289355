using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
   public void Start()
   {
      Time.timeScale = 0.0f;
      Time.fixedDeltaTime = 0.0f;
      Cursor.visible = true;
      Cursor.lockState = CursorLockMode.None;
   }

   public void GoToScene(string scene)
   {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene, LoadSceneMode.Single);
   }
}