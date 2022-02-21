using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Scene 1");
    }

    public void OnQuitbutton()
    {
        Application.Quit();
    }
}
