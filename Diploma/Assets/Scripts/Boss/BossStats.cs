using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DIP
{
    public class BossStats : MonoBehaviour
    {
        Animator animator;
        public GameObject VictoryTest;

        public static int bossHP = 200;
        public int currentbossHP;
        
        private void Awake()
        {
            animator = GetComponentInChildren<Animator>();
        }

        private void Start()
        {
            currentbossHP = bossHP;
        }

        public void TakeDamage(int damage)
        {
            currentbossHP = currentbossHP-damage; // текущее значение ХП от полученного урона

            if (currentbossHP <= 0)
            {
                animator.SetTrigger("death");
                GetComponent<Collider>().enabled = false;
                Invoke(nameof(GameVictory), 3f);
                Invoke(nameof(HandleBossDeath), 10f);
                VictoryTest.SetActive(false);
            }
            else 
            {
                animator.SetTrigger("damage");
            }
        }

        private void GameVictory()
        {
            VictoryTest.SetActive(true);
        }

        private void HandleBossDeath()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
