using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Person : MonoBehaviour
{
    public float speed;

    public bool canMove;

    public bool denied;


    // Name

    public string[] firstNames;

    public string[] lastNames;

    public Text nameTextPass;

    public Text nameTextForm;



    //Date of birth



    // Criminal
    int badRangeNum;

    public bool isBad;

    public Text crimianlText;

    // Skills
    int skillsRangeNum;

    public Text skillsText;

    bool isSkilled;



    //Country

    int countryRangeNum;

    public string badCountry;

    public string goodCountry;

    bool isFromGoodCountry;

    public Text countryText;

    //Religion

    int religionRangeNum;

    public Text religionText;

    bool isMuslim;



    public Canvas passportCanvas;

    public Canvas formCanvas;


    Door DoorOBJ;

    DetectionZone DZ;


    // Use this for initialization
    void Start()
    {
        DoorOBJ = GameObject.Find("Door").GetComponent<Door>();

        DZ = DoorOBJ.GetComponentInChildren<DetectionZone>();


        Forms();

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
            // passportCanvas.gameObject.SetActive(true);

            formCanvas.gameObject.SetActive(true);

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

            if (isFromGoodCountry == true)
            {

            }
            else
            {

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


        countryRangeNum = Random.Range(1, 11);

        if (countryRangeNum <= 8)
        {
            isFromGoodCountry = true;

            countryText.text = "This person is from: " + goodCountry;

            countryText.color = Color.green;
        }
        else
        {
            isFromGoodCountry = false;

            countryText.text = "This person is from: " + badCountry;

            countryText.color = Color.red;
        }


    }

    void Forms()
    {


        crimianlText = GameObject.Find("Crime Text").GetComponent<Text>();

        skillsText = GameObject.Find("Skills Text").GetComponent<Text>();

        countryText = GameObject.Find("Country Text").GetComponent<Text>();


        // passportCanvas = GameObject.Find("Passport Canvas").GetComponent<Canvas>();

        formCanvas = GameObject.Find("Asuylm form Canvas").GetComponent<Canvas>();


       
        


        // passportCanvas.gameObject.SetActive(false);

        formCanvas.gameObject.SetActive(false);

    }
}
