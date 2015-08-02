using UnityEngine;
//using UnityEngine.UI;
using System.Collections;

public class DetectionZone : MonoBehaviour
{

    //public Text questionText;

    public bool canMakeChoice;

    public GameObject personOBJ;

   

    // Use this for initialization
    void Start()
    {
        // questionText.gameObject.SetActive(false);

    

    }

    // Update is called once per frame
    void Update()
    {

       

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Person")
        {
            personOBJ = col.gameObject;

            //print("Hit");

            //questionText.gameObject.SetActive(true);

            canMakeChoice = true;
        }
        else
        {
            canMakeChoice = false;
        }

    }
}
