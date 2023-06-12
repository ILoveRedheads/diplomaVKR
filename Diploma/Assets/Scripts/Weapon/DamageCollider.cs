using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIP
{
    public class DamageCollider : MonoBehaviour
    {
        Collider damageCollider; // коллайдер

        public int currentWeaponDamage = 20; // урон оружия

        private void Awake()
        {
            damageCollider = GetComponent<Collider>();
            damageCollider.gameObject.SetActive(true); // делаем активным
            damageCollider.isTrigger = true; // триггер, по умолчанию true
            damageCollider.enabled = false; // коллайдер может включаться и выключаться, по умолчанию false
        }


        // нижние 2 метода нужны для включения и выключения именно коллайдера, а не всего объекта
        public void EnableDamageCollider() // включить коллайдер
        {
            damageCollider.enabled = true;
        }

        public void DisaleDamageCollider() // выключить коллайдер
        {
            damageCollider.enabled = false;
        }

        private void OnTriggerEnter(Collider collision) // коллизия - когда коллайдер сталкивается с чем-либо
        {
            if (collision.tag == "Player") // хитовать всех, у кого есть скрипт playerstats, то есть, игрока
            {
                PlayerStats playerStats = collision.GetComponent<PlayerStats>();

                if (playerStats != null)
                {
                    playerStats.TakeDamage(currentWeaponDamage);
                }
            }

            if (collision.tag == "Boss") // хитовать всех, у кого есть скрипт playerstats, то есть, игрока
            {
                BossStats bossStats = collision.GetComponent<BossStats>();

                if (bossStats != null)
                {
                    bossStats.TakeDamage(currentWeaponDamage);
                }
            } 

            if (collision.tag == "Enemy") // хитовать всех, у кого есть скрипт enemystats, то есть, врагов
            {
                EnemyStats enemyStats = collision.GetComponent<EnemyStats>();

                if (enemyStats != null)
                {
                    enemyStats.TakeDamage(currentWeaponDamage);
                }
            }
            
        }
    }
}
