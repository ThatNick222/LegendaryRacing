using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownFive : MonoBehaviour
{
  //  public GameObject BeforeStart;
    public GameObject DownCount;

    //public GameObject CarController;
  
    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine (CountDownStart());
    }
    IEnumerator CountDownStart()
    {
yield return new WaitForSeconds(0.5f);
DownCount.GetComponent<Text>().text = "3";
DownCount.SetActive(true);

yield return new WaitForSeconds(1f);
DownCount.SetActive(false);
DownCount.GetComponent<Text>().text = "2";
DownCount.SetActive(true);

yield return new WaitForSeconds(1f);
DownCount.SetActive(false);
DownCount.GetComponent<Text>().text = "1";
DownCount.SetActive(true);

yield return new WaitForSeconds(1f);
DownCount.SetActive(false);
DownCount.GetComponent<Text>().text = "Go";
DownCount.SetActive(true);

GameObject.Find("Free_Racing_Car_Carbon").GetComponent<CamaroController>().enabled = true;
GameObject.Find("Npc2").GetComponent<NPCController>().enabled = true;
GameObject.Find("Npc2").GetComponent<Pilotik>().enabled = true;
GameObject.Find("NPCBlue").GetComponent<NPCController>().enabled = true;
GameObject.Find("NPCBlue").GetComponent<Pilotik>().enabled = true;

UpCountWatch.stopwatchActive = true;
//TimerControl.timer = true;

DownCount.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
      
            

        
       
    }
}
