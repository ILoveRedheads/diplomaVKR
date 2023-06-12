using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIP
{
    public class IncreaseEnemyHP : MonoBehaviour
    {
        public void BuffEnemyHP()
        {
            EnemyStats.enemyHP = 150;
        }
    }
}
