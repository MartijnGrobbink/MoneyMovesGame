using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FruitStore_Script : MonoBehaviour
{
    private DestroyNpc Head;

    public TMP_Text StorelevelText;
    public TMP_Text StoreProductValueText;
    public TMP_Text StoreUpgradeCostText;
    public TMP_Text SpentText;

    public GameObject[] levels;
    public GameObject SpentHolder;

    public int Storelevel = 0;
    int i = 0;
    public double StoreProductValue = 0;
    public double StoreCostMultiplier = 0;
    public double StoreUpgradeCost = 0;
    public double StoreProductValueMultiplier = 0;
    public double NpcValue = 0;
    public int current_level = 0;
    public float timer;
    
    // Start is called before the first frame update
    void Start(){
    Head = GameObject.FindObjectOfType<DestroyNpc>();
    StoreUpgradeCostText.text = StoreUpgradeCost.ToString();
    StorelevelText.text = Storelevel.ToString();
    StoreProductValueText.text = StoreProductValue.ToString();
    }
    void Update(){
        if(i == 1){
        timer -= Time.deltaTime;
        SpentHolder.SetActive(true);
        }
        if (timer<=0) {
            timer = 1;
            i = 0;
            SpentHolder.SetActive(false);
        }
    }
   
    // Level up the store when clicked
    public void LevelUpOnClick(){
        if(Head.Balance >= StoreUpgradeCost){
            Head.Balance = Head.Balance - StoreUpgradeCost;
            SpentText.text = ("-" + StoreUpgradeCost).ToString();
            i++;
        Storelevel++;
        StoreUpgradeCost = StoreUpgradeCost * StoreCostMultiplier;
        StoreProductValue = (Storelevel * StoreProductValueMultiplier);

        if (current_level < levels.Length - 1)
        {
            current_level++;
            SwitchObjects(current_level);
        }
            StorelevelText.text = Storelevel.ToString();
            StoreProductValueText.text = StoreProductValue.ToString();
            StoreUpgradeCostText.text = StoreUpgradeCost.ToString();
            
        } else
        {
            Debug.Log("Need more money");
        }        
    }
     public void SwitchObjects(int lvl)
    {
        for(int a = 0; a<levels.Length; a++)
        {
            if (a == lvl)
                levels[a].SetActive(true);
            else
                levels[a].SetActive(false);
            
        }
    }
}
