using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
  public void Play ()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Exit_()
    {
        Application.Quit();
    }
}
