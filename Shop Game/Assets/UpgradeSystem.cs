using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeSystem : MonoBehaviour
{
    
    public GameObject[] levels;
    public int current_level = 0;
    
    public void Upgrade()
    {

        if (current_level < levels.Length - 1)
        {
            current_level++;
            SwitchObjects(current_level);
            
        }
    }


    public void SwitchObjects(int lvl)
    {
        for(int a = 0; a<levels.Length; a++)
        {
            if (a == lvl)
                levels[a].SetActive(true);
            else
                levels[a].SetActive(false);
            
            
            
        }
    }

    
  
}
