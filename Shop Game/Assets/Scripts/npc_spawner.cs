using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_spawner : MonoBehaviour
{
    public GameObject npc;
    public Transform npcpos;
    public float timer;
    private BuildMenu_Script BuildMenu;
    void Start()
    {
        BuildMenu = GameObject.FindObjectOfType<BuildMenu_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        if(BuildMenu.Butcherexist || BuildMenu.Fruitexist || BuildMenu.Bakkeryexist){
        timer -= Time.deltaTime;
        if (timer<=0) {
            Instantiate(npc, npcpos.position, npcpos.rotation).SetActive(true);
            
            timer = Random.Range(4, 8);
            }
        }
    }
}
