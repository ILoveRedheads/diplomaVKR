using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DIP
{
    public class ChangeResolution : MonoBehaviour
    {
        public Dropdown Dropdown;
        public void Change()
        {
            if(Dropdown.value == 0)
            {
                Screen.SetResolution(1367, 768, true);
            }
            else if(Dropdown.value == 1)
            {
                Screen.SetResolution(1600, 900, true);
            }
            else if(Dropdown.value == 2)
            {
                Screen.SetResolution(1920, 1080, true);
            }
        }
    }
}
