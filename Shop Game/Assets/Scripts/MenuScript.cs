using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
int i = 0;
public GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenMenu(){
    if (i == 0){
            Menu.SetActive(true);
            i++;
        }else{ 
            Menu.SetActive(false);
            i = 0;
        }
    }
    public void ExitButton(){
        Menu.SetActive(false);
        i = 0;
    }
}
