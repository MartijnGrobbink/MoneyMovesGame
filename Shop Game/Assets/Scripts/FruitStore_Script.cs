using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FruitStore_Script : MonoBehaviour
{
    private DestroyNPC Head;

    public TMP_Text StorelevelText;
    public TMP_Text StoreProductValueText;
    public TMP_Text StoreUpgradeCostText;

    public GameObject[] levels;

    public int Storelevel = 0;
    public double StoreProductValue = 0;
    public double StoreCostMultiplier = 0;
    public double StoreUpgradeCost = 0;
    public double StoreProductValueMultiplier = 0;
    public double NpcValue = 0;
    public int current_level = 0;
    
    // Start is called before the first frame update
    void Start(){
    Head = GameObject.FindObjectOfType<DestroyNPC>();
    StoreUpgradeCostText.text = StoreUpgradeCost.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
   
    // Level up the store when clicked
    public void LevelUpOnClick(){
        if(Head.Balance >= StoreUpgradeCost){
        Head.Balance = Head.Balance - StoreUpgradeCost;
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
