using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DestroyNPC : MonoBehaviour
{
    private Npc_Script NPC;

    public TMP_Text CurrentBalanceText;

    public double Balance = 0;

    // Start is called before the first frame update
    void Start()
    {
        NPC = GameObject.FindObjectOfType<Npc_Script>();
        CurrentBalanceText.text = Balance.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        CurrentBalanceText.text = (Balance + "$").ToString();
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            NPC = GameObject.FindObjectOfType<Npc_Script>();
            Balance = Balance + NPC.NpcValue;
            NPC.NpcValue = 0;
            Destroy(collision.gameObject);
        }
    }
}
