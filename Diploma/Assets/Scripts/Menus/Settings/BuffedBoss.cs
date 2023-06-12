using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIP
{
    public class BuffedBoss : MonoBehaviour
    {
        public void BuffBoss()
        {
            BossStats.bossHP = 250;
            BossDamage.damage = 25;
        }
  
    }
}
