using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esc_press : MonoBehaviour
{
    public GameObject leavemenu;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if (i == 0){
                leavemenu.SetActive(true);
                i++;
        }   else{ 
                leavemenu.SetActive(false);
                i = 0;
            }
        }
    }
    public void leave(){
    Application.Quit();
    }
}
