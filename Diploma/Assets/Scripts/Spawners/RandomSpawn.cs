using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIP
{
    public class RandomSpawn : MonoBehaviour
    {
        public GameObject[] houses; // массив объектов для спауна
        public List<Transform> spawnpoints; // список точек появления

        void Start()
        {
            spawnpoints = new List<Transform>(spawnpoints);
            SpawnHouses();
        }

        void SpawnHouses() // метод спауна
        {
            for (int i = 0; i < houses.Length; i++)
            {
                var spawn = Random.Range(0, spawnpoints.Count); // рандомное количество точек спауна
                Instantiate(houses[i], spawnpoints[spawn].transform.position, Quaternion.identity);
                spawnpoints.RemoveAt(spawn);
            }
        }
    }
}
