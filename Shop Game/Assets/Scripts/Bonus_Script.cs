using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus_Script : MonoBehaviour
{
int i = 0;
public GameObject BonusPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void WhenPressed(){
    if (i == 0){
            BonusPanel.SetActive(true);
            i++;
        }else{ 
            BonusPanel.SetActive(false);
            i = 0;
            }
    }
}
