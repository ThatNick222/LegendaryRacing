using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Pilotik : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> trackPoints;
    public int currentCheckPoint;
    public float numOfLaps;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        trackPoints = GameObject.FindGameObjectsWithTag("CheckPoint").ToList<GameObject>();
        currentCheckPoint = 0;
        timer = 5;
    }

    // Update is called once per frame
    void Update()
    {

        if(GetComponent<Rigidbody>().velocity.magnitude <1)
        {
           // timer -= Time.deltaTime;
            if(timer < 0)
            {
                transform.position = trackPoints[currentCheckPoint].transform.position;
                transform.rotation = trackPoints[currentCheckPoint].transform.rotation;
                timer = 5;
            }
        }

       // GetComponent<NegativeController>().turnValue = 0;
        GetComponent<NPCController>().goValue = 0.01f;
        if(GetComponent<Rigidbody>().velocity.magnitude > 15)
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * 5;
        }
        RaycastHit frontObj;
        if (Physics.Raycast(transform.position, transform.forward, out frontObj))
        {
            if (frontObj.transform.tag == "CheckPoint")
            {
                if (frontObj.transform.gameObject.Equals(trackPoints[currentCheckPoint]))
                {
                    GetComponent<NPCController>().goValue = 1;
                    GetComponent<NPCController>().turnValue = 0;
                }
            }
        }
        RaycastHit rightObj;
        if (Physics.Raycast(transform.position, transform.forward + transform.right, out rightObj))
        {
            Debug.DrawLine(transform.position, rightObj.transform.position, Color.yellow);
            if (rightObj.transform.tag == "CheckPoint")
            {
                if (rightObj.transform.gameObject.Equals(trackPoints[currentCheckPoint]))
                {
                    GetComponent<NPCController>().turnValue = 1;
                    GetComponent<NPCController>().goValue = 0.2f;
                }

            }
        }
        RaycastHit leftObj;
        if(Physics.Raycast(transform.position, transform.forward - transform.right, out leftObj))
        {
            Debug.DrawLine(transform.position, leftObj.transform.position, Color.yellow);
            if (leftObj.transform.tag == "CheckPoint")
            {
                if(leftObj.transform.gameObject.Equals(trackPoints[currentCheckPoint]))
                {
                    GetComponent<NPCController>().turnValue = -1;
                    GetComponent<NPCController>().goValue = 0.2f;
                }
            }
        }

      
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CheckPoint")
        {
            currentCheckPoint++;
            if (currentCheckPoint == trackPoints.Count)
            {
                numOfLaps++;
                currentCheckPoint = 0;
            }
        }
    }
}
