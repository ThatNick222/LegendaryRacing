using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AiPilot : MonoBehaviour
{
    public List<GameObject> trackPath;
    public int currentPosition;
    Rigidbody carRigidBody;
    float timerToRespawn;
    
    // Start is called before the first frame update
    void Start()
    {
        timerToRespawn = 0;
        carRigidBody = GetComponent<Rigidbody>();
        trackPath = GameObject.FindGameObjectsWithTag("CheckPoint").ToList<GameObject>();
        currentPosition = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        if (carRigidBody.velocity.magnitude < 1)
        {
            timerToRespawn += Time.deltaTime;
            if (timerToRespawn > 5)
            {
                 
                if (currentPosition != 0)
                {
                    transform.rotation = trackPath[currentPosition - 1].transform.rotation;
                    transform.position = trackPath[currentPosition - 1].transform.position;
                }
                else
                {
                    transform.position = trackPath[trackPath.Count - 1].transform.position;
                    transform.rotation = trackPath[trackPath.Count - 1].transform.rotation;
                }

                timerToRespawn = 0;
            }
        }

        RaycastHit frontObj;
        if (Physics.Raycast(transform.position, transform.forward, out frontObj))
        {
            if (frontObj.transform.tag == "CheckPoint")
            {
                if (frontObj.transform.gameObject.Equals(trackPath[currentPosition]))
                {
                    GetComponent<AICarController>().goValue = 1;
                    GetComponent<AICarController>().turnValue = 0;
                }
            }
        }

        RaycastHit rightObj;
        if (Physics.Raycast(transform.position, transform.forward + transform.right, out rightObj))
        {
            Debug.DrawLine(transform.position, rightObj.transform.position, Color.yellow);
            if (frontObj.transform.tag == "CheckPoint")
            {
                if (rightObj.transform.gameObject.Equals(trackPath[currentPosition]))
                {
                    GetComponent<AICarController>().turnValue = 1;
                    GetComponent<AICarController>().goValue = 0f;
                }
            }


        }


        RaycastHit leftObj;
        if (Physics.Raycast(transform.position, transform.forward - transform.right, out leftObj))
        {
            Debug.DrawLine(transform.position, leftObj.transform.position, Color.yellow);
            if (frontObj.transform.tag == "CheckPoint")
            {
                if (leftObj.transform.gameObject.Equals(trackPath[currentPosition]))
                {
                    GetComponent<AICarController>().turnValue = -1;
                    GetComponent<AICarController>().goValue = 0;
                }
            }
        }

        if(!Physics.Raycast(transform.position, transform.forward - transform.right))
        {
            if (!Physics.Raycast(transform.position, transform.forward + transform.right))
            {
                if (!Physics.Raycast(transform.position, transform.forward))
                {
                     
                }
            }
        }
            
                
                      
    }


    //функция для увечеления currentCheckPoint должна быть здесь 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CheckPoint")
        {
            currentPosition++;
            if (currentPosition == trackPath.Count)
                currentPosition = 0;
        }
    }
}
