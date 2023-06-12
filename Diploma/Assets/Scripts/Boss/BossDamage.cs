using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIP
{
    public class BossDamage : MonoBehaviour
    {
        public static int damage = 20;

        private void OnTriggerEnter(Collider other) // когда задет триггер
        {
            PlayerStats playerStats = other.GetComponent<PlayerStats>();
            /* вызываем playerstats, чтобы дамажило только объект
            в котором есть playerstats, то есть, только игрока */
            if (playerStats != null)
            {
                playerStats.TakeDamage(damage);
            }
        }
    }
}
