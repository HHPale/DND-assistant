using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Create_a_character()
    {
        SceneManager.LoadScene(1);
    }

    public void Load_a_character()
    {
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public  void DND_3r()
    {
        SceneManager.LoadScene(1);
    }

    public void DND_3r_PHB()
    {
        SceneManager.LoadScene(3);
    }
}
