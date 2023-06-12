using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace DIP
{
    public class PlayerStats : MonoBehaviour
    {
        public GameObject DeadTest;
        public GameObject RanOutOfTime;
        public HealthBar healthbar;
        public ManaBar manabar;

        AnimatorHandler animatorHandler;

        public static int maxHealth = 100; // макс ХП 
        public int currentHealth; // текущее ХП
        public static int maxMana = 100; // макс мана
        public int currentMana; // текущая мана
        public static bool isGameOver;
        public static int wasteMana = 10;
        public static int healplayer = 20;
        public float levelTimer;
        

        private void Awake()
        {
            levelTimer = Random.Range(180, 300);
            animatorHandler = GetComponentInChildren<AnimatorHandler>();
        }

        public void Start()
        {
            currentHealth = maxHealth;
            currentMana = maxMana;
            healthbar.SetMaxHealth(maxHealth);
            manabar.SetMaxMana(maxMana);
        }

        void Update()
        {
            
            levelTimer -= Time.deltaTime;
            if(levelTimer <= 0) 
            {
                Invoke(nameof(TimeOut), 1f);
                Invoke(nameof(HandlePlayerDeath), 6f);
                RanOutOfTime.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                animatorHandler.PlayTargetAnimation("Healing", true);
                ManaWaste();
                RestoreHealth();

            }

        }

        public void TakeDamage(int damage)
        {
            currentHealth = currentHealth-damage; // текущее значение ХП от полученного урона

            healthbar.SetCurrentHealth(currentHealth); // текущее здоровье на ХП баре

            animatorHandler.PlayTargetAnimation("impact", true); // анимация получения урона

            if (currentHealth <= 0) // смерть
            {
                currentHealth = 0;
                animatorHandler.PlayTargetAnimation("death", true); // анимация смерти
                Invoke(nameof(PlayerDead), 1f);
                Invoke(nameof(HandlePlayerDeath), 6f);
                DeadTest.SetActive(false);
                //HANDLE PLAYER DEATH
            } 
        }

        public void ManaWaste()
        {
            currentMana = currentMana-wasteMana; // текущее значение ХП от полученного урона
            manabar.SetCurrentMana(currentMana); // текущее здоровье на ХП баре
            if (currentMana < 0)
            {
                currentMana = 0;
                wasteMana = 0;
                healplayer = 0;
            }

        }

        private void RestoreHealth()
        {
            currentHealth = currentHealth + healplayer;
            healthbar.SetCurrentHealth(currentHealth);
            if (currentHealth >= 100)
            {
                currentHealth = 100;
            }
        }

        private void HandlePlayerDeath()
        {
            SceneManager.LoadScene("Game");
        }

        private void PlayerDead()
        {
            DeadTest.SetActive(true);
        }

        private void TimeOut()
        {
            RanOutOfTime.SetActive(true);
        }

    }
}
