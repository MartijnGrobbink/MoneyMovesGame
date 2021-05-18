using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FruitStore_Script : MonoBehaviour
{
    private Npc_Script NPC;

    public TMP_Text StorelevelText;
    public TMP_Text StoreProductValueText;
    public TMP_Text StoreUpgradeCostText;

    int Storelevel = 0;
    public double StoreProductValue = 0;
    public double StoreCostMultiplier = 0;
    public double StoreUpgradeCost = 0;
    public double StoreProductValueMultiplier = 0;
    public double NpcValue = 0;
    
    // Start is called before the first frame update
    void Start(){
    NPC = GameObject.FindObjectOfType<Npc_Script>();
     StoreUpgradeCostText.text = StoreUpgradeCost.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    //StoreUpgradeCostText.text = FruitStore.StoreUpgradeCost.ToString();
   }
   
    // Level up the store when clicked
    public void LevelUpOnClick(){
        if(NPC.Balance >= StoreUpgradeCost){
        NPC.Balance = NPC.Balance - StoreUpgradeCost;
        Storelevel++;
        StoreUpgradeCost = StoreUpgradeCost + StoreCostMultiplier;
        StoreProductValue = (Storelevel * StoreProductValueMultiplier);
            StorelevelText.text = Storelevel.ToString();
            StoreProductValueText.text = StoreProductValue.ToString();
            StoreUpgradeCostText.text = StoreUpgradeCost.ToString();
        } else
        {
            Debug.Log("Need more money");
        }
    }
}
