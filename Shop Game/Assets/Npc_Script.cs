using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Npc_Script : MonoBehaviour
{
  private FruitStore_Script FruitShop;
    private Bakkery_Script BreadShop;
    public TMP_Text NpcValueText;
    public TMP_Text CurrentBalanceText;
    private double NpcValue = 0;

    public double Balance = 0;
    //public double Value = 0;
    // Start is called before the first frame update
    void Start()
    {
        FruitShop = GameObject.FindObjectOfType<FruitStore_Script>();
        BreadShop = GameObject.FindObjectOfType<Bakkery_Script>();
        Debug.Log(FruitShop);
        CurrentBalanceText.text = Balance.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        //NpcValue = BreadShop.NpcValue + FruitShop.NpcValue;
        NpcValueText.text = NpcValue.ToString();
        CurrentBalanceText.text = (Balance + "$").ToString();
    }
    public void FinishOrderOnClick(){ 
        Debug.Log(NpcValue);
        Balance = Balance + NpcValue;
        NpcValue = 0;
    }
    public void GenerateOnClick(){
        string[] fruitshopstring = new string[] {"true", "false"};
        string FruitshopRandom = fruitshopstring [Random.Range(0, fruitshopstring.Length)];
        if(FruitshopRandom.Contains("true")){NpcValue = NpcValue + FruitShop.StoreProductValue; Debug.Log(NpcValue);} else { 
        Debug.Log("not get fruit");}

        string[] breadshopstring = new string[] {"true", "false"};
        string BreadshopRandom = breadshopstring [Random.Range(0, breadshopstring.Length)];
        if(BreadshopRandom.Contains("true")){NpcValue = NpcValue + BreadShop.StoreProductValue; Debug.Log(NpcValue);} else { 
        Debug.Log("not get bread");}
    }
}
//THAT SUCKS
