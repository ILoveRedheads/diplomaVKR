using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIP
{
    public class EnemyStats : MonoBehaviour
    {
        Animator animator;

        public static int enemyHP = 100;
        public int currentenemyHP;
        private void Awake()
        {
            animator = GetComponentInChildren<Animator>();
        }

        private void Start()
        {
            currentenemyHP = enemyHP;
        }

        public void TakeDamage(int damage)
        {
            currentenemyHP = currentenemyHP-damage; // текущее значение ХП от полученного урона

            if (currentenemyHP <= 0)
            {
                animator.SetTrigger("death");
                GetComponent<Collider>().enabled = false;
            }
            else 
            {
                animator.SetTrigger("damage");
            }
        }

    }
}
