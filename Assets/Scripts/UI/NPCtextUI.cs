using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCtextUI : MonoBehaviour
{
    public GameObject Player;
    public GameObject NPC1;
    public GameObject NPC2;
    public GameObject NPC3;
    public GameObject UI1;
    public GameObject UI2;
    public GameObject UI3;
    float NPC1Distance = 0f;
    float NPC2Distance = 0f;
    float NPC3Distance = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NPC1Distance = Vector2.Distance(Player.transform.position, NPC1.transform.position);
        NPC2Distance = Vector2.Distance(Player.transform.position, NPC2.transform.position);
        NPC3Distance = Vector2.Distance(Player.transform.position, NPC3.transform.position);

        if (NPC1Distance < 5f)
            UI1.SetActive(true);
        else if (NPC2Distance < 5f)
            UI2.SetActive(true);
        else if (NPC3Distance < 5f)
            UI3.SetActive(true);
        else
        {
            UI1.SetActive(false);
            UI2.SetActive(false);
            UI3.SetActive(false);
        }
    }

    void NPCUI()
    {

    }


}
