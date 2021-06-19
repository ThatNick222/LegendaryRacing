using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NewAiPilot : MonoBehaviour
{
    List<GameObject> TrackPoints;
    int currentCheckPoint;
    // Start is called before the first frame update
    void Start()
    {
        TrackPoints = GameObject.FindGameObjectsWithTag("Checkpoint").ToList<GameObject>();
        currentCheckPoint = 0;
    }


    // Update is called once per frame
    void Update()
    {
RaycastHit frontObj;
if(Physics.Raycast(transform.position, transform.forward, out frontObj))
{
    if(frontObj.transform.tag == "Checkpoint")
    {
        if(frontObj.transform.gameObject.Equals(TrackPoints[currentCheckPoint]))
        {
            GetComponent<NPCController>().goValue = 1;
            GetComponent<NPCController>().turnValue = 0;
        }
    }
}
RaycastHit rightObj;
if (Physics.Raycast(transform.position, transform.forward + transform.right, out rightObj))
{
    if(rightObj.transform.tag =="Checkpoint")
    {
        if (rightObj.transform.gameObject.Equals(TrackPoints[currentCheckPoint]))
        {
            GetComponent<NPCController>().goValue = 0.2f;
            GetComponent<NPCController>().turnValue = 1f;
        }
    }
}
    }
}
