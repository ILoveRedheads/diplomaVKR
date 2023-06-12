using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIP
{
    public class IncreaseEnemyDamage : MonoBehaviour
    {
        public void ChangeDamage()
        {
            DamageScript.damage = 20;
        }
    }
}
