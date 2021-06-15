using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;

public class Npc_Script : MonoBehaviour
{
    private Head_Script Head;
    
    public Transform[] wayPointList;
    public Transform[] wayPointList1;
    public Transform[] wayPointList2;
    public Transform[] wayPointList3;
    public Transform[] wayPointList4;
    public Transform[] wayPointList5;
    public Transform[] wayPointList6;
    public Transform[] wayPointList7;

    public GameObject[] skins;

    Transform targetWayPoint;
    public float speed = 4f;

    private FruitStore_Script FruitShop;
    private Bakkery_Script BreadShop;
    private Butcher_Script Butcher;
    private BuildMenu_Script BuildMenu;
    public TMP_Text NpcValueText;
    bool ChooseFruit = false;
    bool ChooseBakkery = false;
    bool ChooseButcher = false;
    public double NpcValue = 0;
    public int currentWayPoint = 0;
    int CashierWaypoint;
    // Start is called before the first frame update
    void Start()
    {
        Head = GameObject.FindObjectOfType<Head_Script>();
        FruitShop = GameObject.FindObjectOfType<FruitStore_Script>();
        BreadShop = GameObject.FindObjectOfType<Bakkery_Script>();
        Butcher = GameObject.FindObjectOfType<Butcher_Script>();
        BuildMenu = GameObject.FindObjectOfType<BuildMenu_Script>();
        if(BuildMenu.Fruitexist == true || BuildMenu.Bakkeryexist == true || BuildMenu.Butcherexist == true){
            ChooseShop();
            int pickedskin = Random.Range(0, skins.Length);
            this.skins[pickedskin].SetActive(true);
        }
    }

    void ChooseShop(){
        while(NpcValue == 0){
        if(BuildMenu.Fruitexist == true){
            string[] fruitshopstring = new string[] {"true", "false"};
            string FruitshopRandom = fruitshopstring [Random.Range(0, fruitshopstring.Length)];
            if(FruitshopRandom.Contains("true")){NpcValue = NpcValue + FruitShop.StoreProductValue; ChooseFruit = true;}
        }
        if(BuildMenu.Bakkeryexist == true){
            string[] breadshopstring = new string[] {"true", "false"};
            string BreadshopRandom = breadshopstring [Random.Range(0, breadshopstring.Length)];
            if(BreadshopRandom.Contains("true")){NpcValue = NpcValue + BreadShop.StoreProductValue; ChooseBakkery = true;}
        }
        if(BuildMenu.Butcherexist == true){
            string[] butcherstring = new string[] {"true", "false"};
            string ButcherRandom = butcherstring [Random.Range(0, butcherstring.Length)];
            if(ButcherRandom.Contains("true")){NpcValue = NpcValue + Butcher.StoreProductValue; ChooseButcher = true;}
            }
        } 
        if(NpcValue > 0){ ChoosePath();}
    }
    void ChoosePath(){
        if(ChooseFruit == true && ChooseBakkery == true && ChooseButcher == true){wayPointList = wayPointList1;CashierWaypoint = 11;Debug.Log("all");}
        else if(ChooseFruit == true && ChooseBakkery ==true){wayPointList = wayPointList2;CashierWaypoint = 12;Debug.Log("fruit & bread");}
        else if(ChooseBakkery == true && ChooseButcher == true){wayPointList = wayPointList3;CashierWaypoint = 11;Debug.Log("meat & bread");}
        else if(ChooseFruit == true && ChooseButcher == true){wayPointList = wayPointList4;CashierWaypoint = 10;Debug.Log("meat & fruit");}
        else if(ChooseFruit == true){wayPointList = wayPointList5;CashierWaypoint = 7;Debug.Log("fruit");}
        else if(ChooseBakkery == true){wayPointList = wayPointList6;CashierWaypoint = 9;Debug.Log("bread");}
        else if(ChooseButcher == true){wayPointList = wayPointList7;CashierWaypoint = 10;Debug.Log("meat");}
    }
    void Update()
    {

        if (currentWayPoint < this.wayPointList.Length)
        {
            
            if (targetWayPoint == null){
                targetWayPoint = wayPointList[currentWayPoint];
            }
            NpcWalk();
        }
    } 
    void NpcWalk()
    {
        transform.forward = Vector3.RotateTowards(transform.forward, targetWayPoint.position - transform.position, speed * Time.deltaTime, 0.0f);

        transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position, speed * Time.deltaTime);


        if (transform.position == targetWayPoint.position)
        {
            currentWayPoint++;
            targetWayPoint = wayPointList[currentWayPoint];
            if(currentWayPoint == CashierWaypoint){
            Head.Balance = Head.Balance + NpcValue;
            NpcValue = 0;
            }
            if (currentWayPoint == this.wayPointList.Length -1){
            Destroy(gameObject);
            }
        }
    }
}