using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ListOfNpc : MonoBehaviour
{
    public List<GameObject> npcList;
    // Start is called before the first frame update
    void Start()
    {
        npcList = GameObject.FindGameObjectsWithTag("NPC").ToList<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "NPC list";
        npcList = npcList.OrderBy(o => o.GetComponent<AiPilot>().currentPosition).ToList<GameObject>();
        for (int i=0;i<npcList.Count;i++)
        {
            GetComponent<Text>().text += '\n' + npcList[i].name;
        }

    }
}
