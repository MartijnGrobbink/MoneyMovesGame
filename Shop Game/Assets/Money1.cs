using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money1 : MonoBehaviour
{
    public static int _money=100 ;
    public Text text;
    
    




     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MoneyPoint")
        {
            
            text.text = "" + _money;

        }
        

        
    }
    
   

    

    



}

