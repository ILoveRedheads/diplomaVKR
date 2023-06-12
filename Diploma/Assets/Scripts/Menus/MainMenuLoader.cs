using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DIP
{
    public class MainMenuLoader : MonoBehaviour
    {
        public void GotoSettings()
        {
            SceneManager.LoadScene("Settings");
        }
        public void ExitGame()
        {
            Application.Quit();
        }
    }
}
