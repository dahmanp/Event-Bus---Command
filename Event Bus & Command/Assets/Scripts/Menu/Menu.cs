using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ToEventBus()
    {
        SceneManager.LoadScene("EventBus");
    }

    public void ToCommand()
    {
        SceneManager.LoadScene("Command");
    }
}
