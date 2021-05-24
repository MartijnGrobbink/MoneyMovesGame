using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;

public class Npc_Script : MonoBehaviour
{
    private FruitStore_Script FruitShop;
    private Bakkery_Script BreadShop;
    public TMP_Text NpcValueText;
    public double NpcValue = 0;

    //public double Value = 0;
    // Start is called before the first frame update
    void Start()
    {
        FruitShop = GameObject.FindObjectOfType<FruitStore_Script>();
        BreadShop = GameObject.FindObjectOfType<Bakkery_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        NpcValueText.text = NpcValue.ToString();
    }
    public void GenerateOnClick(){
        if(FruitShop.Storelevel >= 1 || BreadShop.Storelevel >= 1){
            while(NpcValue == 0){
            string[] fruitshopstring = new string[] {"true", "false"};
            string FruitshopRandom = fruitshopstring [Random.Range(0, fruitshopstring.Length)];
            if(FruitshopRandom.Contains("true")){NpcValue = NpcValue + FruitShop.StoreProductValue;} else { 
            Debug.Log("not get fruit");}

            string[] breadshopstring = new string[] {"true", "false"};
            string BreadshopRandom = breadshopstring [Random.Range(0, breadshopstring.Length)];
            if(BreadshopRandom.Contains("true")){NpcValue = NpcValue + BreadShop.StoreProductValue;} else { 
            Debug.Log("not get bread");}
            }
        }
    }
}