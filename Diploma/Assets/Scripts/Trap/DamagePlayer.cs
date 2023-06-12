using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIP
{
    public class DamagePlayer : MonoBehaviour
    {
        public int damage = 25; // урон от ловушки

        private void OnTriggerEnter(Collider other) // когда задет триггер
        {
            PlayerStats playerStats = other.GetComponent<PlayerStats>(); // вызываем скрипт и PlayerStats
            // Если в объекте присутствует скрипт PlayerStats, то нанести урон
            if (playerStats != null)
            {
                playerStats.TakeDamage(damage);
            }
        }
    }
}
