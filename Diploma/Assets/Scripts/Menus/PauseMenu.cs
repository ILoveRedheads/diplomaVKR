using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DIP
{
    public class PauseMenu : MonoBehaviour
    {
        public static bool PauseGame;
        public GameObject pauseMenu; 

        void Update()
        {
           if (Input.GetKeyDown(KeyCode.Escape)) //если нажата escape
           {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
           } 
        }

        public void Resume() // возврат к игре 
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f; // включение времени
            PauseGame = false;
        }

        public void Pause() // Включение паузы 
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f; // остановка времени
            PauseGame = true;
        }

        

    }
}
