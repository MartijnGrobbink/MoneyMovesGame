using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_spawner : MonoBehaviour
{
    public GameObject npc;
    public Transform npcpos;
    public float timer;
    private FruitStore_Script FruitShop;
    private Bakkery_Script BreadShop;
    void Start()
    {
        FruitShop = GameObject.FindObjectOfType<FruitStore_Script>();
        BreadShop = GameObject.FindObjectOfType<Bakkery_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        if(FruitShop.Storelevel >= 1 || BreadShop.Storelevel >= 1){
        timer -= Time.deltaTime;
        if (timer<=0) {
            Instantiate(npc, npcpos.position, npcpos.rotation);
            timer = 5;
        }
        }
    }
}
