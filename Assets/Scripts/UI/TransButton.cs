using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransButton : MonoBehaviour
{
  public void RestartScene()
  {
    Scene activeScene = SceneManager.GetActiveScene();
    if (activeScene == null) return;
    SceneManager.LoadScene(activeScene.name);
  }

  public void GoToScene(int value)
  {
    SceneManager.LoadScene(value);
  }
}
