using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIP
{
    public class SpawnEnemy : MonoBehaviour
    {
        public GameObject[] enemies; // массив объектов для спауна
        public List<Transform> enemypoints; // список точек появления

        void Start()
        {
            enemypoints = new List<Transform>(enemypoints);
            SpawnEnemies();
        }

        void SpawnEnemies() // метод спауна
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                var spawn = Random.Range(0, enemypoints.Count); // рандомное количество точек спауна
                Instantiate(enemies[i], enemypoints[spawn].transform.position, Quaternion.identity);
                enemypoints.RemoveAt(spawn);
            }
        }
    }
}
