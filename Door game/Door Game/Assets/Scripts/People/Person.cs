using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Person : MonoBehaviour
{
    public float speed;

    public bool canMove;

    public bool denied;


    public bool isBad;

    public Text crimianlText;

    int rangeNum;

    Door DoorOBJ;

    DetectionZone DZ;

    // Use this for initialization
    void Start()
    {
        DoorOBJ = GameObject.Find("Door").GetComponent<Door>();

        DZ = DoorOBJ.GetComponentInChildren<DetectionZone>();


        crimianlText = GameObject.Find("Crime Text").GetComponent<Text>();

        rangeNum = Random.Range(1, 11);

        if (rangeNum <= 5)
        {
            isBad = false;
        }
        else
        {
            isBad = true;
        }

       // print(rangeNum.ToString());

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

       // DZ = GameObject.FindGameObjectWithTag("Detection").GetComponent<DetectionZone>();

        if (canMove == true)
        {
            transform.Translate(-speed, 0, 0);
        }

        if (denied == true)
        {
            transform.Translate(speed, 0, 0);
        }


        if (DZ.canMakeChoice == true)
        {
            if (isBad == true)
            {
                crimianlText.text = "This person is a criminal";

                crimianlText.color = Color.red;
            }
            else
            {
                crimianlText.text = "This person is a charity worker";

                crimianlText.color = Color.green;
            }
        }


    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (DoorOBJ.madeChoice == false)
        {
            if (col.gameObject.tag == "Detection")
            {
                canMove = false;
            }

        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Exit")
        {
            //print("Exit");

            DoorOBJ.DZ.gameObject.SetActive(true);
        }

        if (col.gameObject.tag == "Destroy")
        {
            Destroy(this.gameObject);
        }
    }
}
