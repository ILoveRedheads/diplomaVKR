using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DIP
{
    public class ButtonTest : MonoBehaviour
    {

      //  private PlayerStats playerHP;
    //    private HealthBar HPBar;

     //   private Slider slider;

       // public static int maxHealth; // максимальное значение ХП
      //  public static int currentHealth; // текущее значение ХП

        // Start is called before the first frame update
        void Start()
        {
           // playerHP = GameObject.FindWithTag("Player").GetComponent<PlayerStats>();

            /*
            HPBar = GameObject.FindWithTag("Health Bar").GetComponent<HealthBar>();

            slider = GameObject.FindWithTag("Health Bar").GetComponent<Slider>();
            */

            
        
        }

        // Update is called once per frame
        public void ChangeHP()
        {
            // PlayerStats.maxHealth =  150;
           // PlayerStats.currentHealth =  150;


            
           /* slider.maxValue = maxHealth; // показатели слайдера 
            slider.value = maxHealth;

            slider.value = currentHealth;
            */
        
        }
    }
}
