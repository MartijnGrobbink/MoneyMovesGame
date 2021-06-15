using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuildMenu_Script : MonoBehaviour
{
    private Head_Script Head;
    public GameObject FruitButton;
    public GameObject BreadButton;
    public GameObject ButcherButton;
    public TMP_Text SpentText;

    public GameObject FruitShop;
    public GameObject Bakkery;
    public GameObject Butcher;
    public GameObject SpentHolder;    

    public int FruitShopBuildCost;
    public int BakkeryBuildCost;
    public int ButcherBuildCost;
    int i = 0;
    public float timer;
    public bool Butcherexist = false;
    public bool Fruitexist = false;
    public bool Bakkeryexist = false;

    // Start is called before the first frame update
    void Start()
    {
    Head = GameObject.FindObjectOfType<Head_Script>();

    }

    void Update()
    {
    if(i >= 1){
        timer -= Time.deltaTime;
        SpentHolder.SetActive(true);
        }
    if (timer<=0) {
        timer = 1;
        i = 0;
        SpentHolder.SetActive(false);
        }
    } 

    public void BuildFruitShop(){
        if(Head.Balance >= FruitShopBuildCost){
            Head.Balance = Head.Balance - FruitShopBuildCost;
            SpentText.text = ("-" + FruitShopBuildCost).ToString();
            FruitShop.SetActive(true);
            Fruitexist = true;
            FruitButton.SetActive(false);
            i++;
        }
    }
    public void BuildBakkery(){
        if(Head.Balance >= FruitShopBuildCost){
            Head.Balance = Head.Balance - BakkeryBuildCost;
            SpentText.text = ("-" + BakkeryBuildCost).ToString();
            Bakkery.SetActive(true);
            Bakkeryexist = true;
            BreadButton.SetActive(false);
            i++;
        }
    }
    public void BuildButcher(){
        if(Head.Balance >= FruitShopBuildCost){
            Head.Balance = Head.Balance - ButcherBuildCost;
            SpentText.text = ("-" + ButcherBuildCost).ToString();
            Butcher.SetActive(true);
            Butcherexist = true;
            ButcherButton.SetActive(false);
            i++;
        }
    }
}



