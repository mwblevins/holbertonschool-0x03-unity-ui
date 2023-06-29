using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
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
