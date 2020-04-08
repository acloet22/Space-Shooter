using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_MenuManager : MonoBehaviour
{
   public void LoadGame()
    {
        SceneManager.LoadScene(1);
        //load the game scene
    }
}
