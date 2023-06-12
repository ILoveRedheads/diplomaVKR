using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DIP
{
    public class GameLoader : MonoBehaviour
    {
        
        public void EnterGame()
        {
            int index = Random.Range(2, 3);
            SceneManager.LoadScene(index);
        }

        public void BackTomenu()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
