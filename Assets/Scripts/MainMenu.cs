using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;
    // Start is called before the first frame update
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
    }

    public void ToggleColorblindMode()
    {
        if (colorblindMode.enabled)
        {
            trapMat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
        else
        {
            trapMat.color = Color.red;
            goalMat.color = Color.green;
        }
    }


    public void QuitMaze()
    {
        #if UNITY_EDITOR
            Debug.Log("Quit Game");
        #else
            Application.Quit();
        #endif
    }
}
