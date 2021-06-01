using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMenuButton : MonoBehaviour
{
public GameObject Menu;
public void OnMouseDown(){
            Menu.SetActive(true);
    }
}

