using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIP
{
    public class SpawnWildFire : MonoBehaviour
    {
        public GameObject[] fireTraps; // массив объектов для спауна
        public List<Transform> fireTrapsPoints; // список точек появления

        void Start()
        {
            fireTrapsPoints = new List<Transform>(fireTrapsPoints);
            SpawnTraps();
        }

        void SpawnTraps() // метод спауна
        {
            for (int i = 0; i < fireTraps.Length; i++)
            {
                var spawn = Random.Range(0, fireTrapsPoints.Count); // Случайное распределение точек спауна
                Instantiate(fireTraps[i], fireTrapsPoints[spawn].transform.position, Quaternion.identity); // Спаун объектов из массива 
                fireTrapsPoints.RemoveAt(spawn); 
            }
        }
    }
}
