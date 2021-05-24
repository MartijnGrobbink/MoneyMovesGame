using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_spawner : MonoBehaviour
{
    public GameObject npc;
    public Transform npcpos;
    public float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer<=0) {
            Instantiate(npc, npcpos.position, npcpos.rotation);
            timer = 10;
        }
    }
}
