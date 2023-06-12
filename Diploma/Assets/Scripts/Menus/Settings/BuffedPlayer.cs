using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIP
{
    public class BuffedPlayer : MonoBehaviour
    {
        public void PlayerBuff()
        {
            PlayerStats.maxHealth = 150;
            PlayerStats.maxMana = 150;
        }
    }
}
