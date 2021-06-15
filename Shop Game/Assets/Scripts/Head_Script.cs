using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Head_Script : MonoBehaviour
{
    public TMP_Text CurrentBalanceText;

    public double Balance = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        CurrentBalanceText.text = (Balance + "$").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentBalanceText.text = (Balance + "$").ToString();
    }
}
