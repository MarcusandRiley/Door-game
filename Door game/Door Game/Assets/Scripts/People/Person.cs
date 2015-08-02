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

    int badRangeNum;


    int skillsRangeNum;

    public Text skillsText;

    bool isSkilled;


    Door DoorOBJ;

    DetectionZone DZ;

    // Use this for initialization
    void Start()
    {
        DoorOBJ = GameObject.Find("Door").GetComponent<Door>();

        DZ = DoorOBJ.GetComponentInChildren<DetectionZone>();


        crimianlText = GameObject.Find("Crime Text").GetComponent<Text>();

        skillsText = GameObject.Find("Skills Text").GetComponent<Text>();

        PersonalAttributes();
     

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
                crimianlText.text = "This person was a criminal";

                crimianlText.color = Color.red;
            }
            else
            {
                crimianlText.text = "This person as no criminal history";

                crimianlText.color = Color.green;
            }

            if (isSkilled == true)
            {
                skillsText.text = "This person is a mechanic";

                skillsText.color = Color.green;
            }
            else
            {
                skillsText.text = "This person is unemployed";

                skillsText.color = Color.red;
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

    void PersonalAttributes()
    {
        badRangeNum = Random.Range(1, 11);

        if (badRangeNum <= 5)
        {
            isBad = false;
        }
        else
        {
            isBad = true;
        }


        skillsRangeNum = Random.Range(1, 6);

        if (skillsRangeNum <= 3)
        {
            isSkilled = true;
        }
        else
        {
            isSkilled = false;
        }


    }
}
