using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIP
{
    public class PlayerAttacker : MonoBehaviour
    {
        AnimatorHandler animatorHandler;
        InputHandler inputHandler;
        public string lastAttack; // последняя атака в комбинации атак

        private void Awake()
        {
            animatorHandler = GetComponentInChildren<AnimatorHandler>();
            inputHandler = GetComponent<InputHandler>();
        }

        public void HandleWeaponCombo(WeaponItem weapon) // комбо атаки - серия атак
        {
            if(inputHandler.comboFlag)
            {
                animatorHandler.anim.SetBool("canDoCombo", false);

                if (lastAttack == weapon.OH_Light_Attack_1)
                {
                    animatorHandler.PlayTargetAnimation(weapon.OH_Light_Attack_2, true);
                }
                if (lastAttack == weapon.OH_Heavy_Attack_1)
                {
                    animatorHandler.PlayTargetAnimation(weapon.OH_Heavy_Attack_2, true);
                }
                

            }
        }

        public void HandleLightAttack(WeaponItem weapon) // легкая атака
        {
            animatorHandler.PlayTargetAnimation(weapon.OH_Light_Attack_1, true);
            lastAttack = weapon.OH_Light_Attack_1;
        }

        public void HandleHeavyAttack(WeaponItem weapon) // тяжелая атака
        {
            animatorHandler.PlayTargetAnimation(weapon.OH_Heavy_Attack_1, true);
            lastAttack = weapon.OH_Heavy_Attack_1; 
        }
    }
}
