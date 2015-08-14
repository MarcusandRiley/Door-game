using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Person : MonoBehaviour
{
    public float speed;

    public bool canMove;

    public bool denied;


    // Name 
    [Header("Name")]

    public Text nametext;

    int personNumber;

    //public string[] firstNames;

    //public string[] lastNames;

    //public Text nameTextPass;

    //public Text nameTextForm;


    //Date

    int day;

    int month;

    [Header("Date")]
    public int year;

    public Text dateText;

    public bool isTooOld;

    //Crime


    [Header("Crime")]
    public bool isBad;

    int badRangeNum;

    public Text crimianlText;

    // Skills

    [Header("Skills")]

    public Text skillsText;

    int skillsRangeNum;

    public bool isSkilled;

    //Country


    [Header("Country")]
    public string[] badCountry;

    public string[] goodCountry;

    public bool isFromGoodCountry;

    int countryRangeNum;

    public Text countryText;


    // public Canvas passportCanvas;

    public Canvas formCanvas;


    Door DoorOBJ;

    DetectionZone DZ;

    GameManagerScript gameManage;

    string counString;


    // Use this for initialization
    void Start()
    {
        DoorOBJ = GameObject.Find("Door").GetComponent<Door>();

        DZ = DoorOBJ.GetComponentInChildren<DetectionZone>();

        gameManage = GameObject.Find("Game Manager").GetComponent<GameManagerScript>();


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

            nametext.text = "# " + personNumber.ToString();



            dateText.text = "" + day + "/" + "" + month + "/" + year;

            //Day 4
            if (isTooOld == true)
            {
                //dateText.color = Color.red;

                dateText.color = Color.green;
            }
            else
            {
                if (gameManage.dayNum >= 4)
                {
                    dateText.color = Color.red;
                }
                else
                {
                    dateText.color = Color.green;
                }

            }


            //IF Its Day 1

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

            //IF Its Day 2
            if (isSkilled == true)
            {
                skillsText.text = "This person is a mechanic";

                skillsText.color = Color.green;
            }
            else
            {
                skillsText.text = "This person is unemployed";

                if (gameManage.dayNum >= 2)
                {
                    skillsText.color = Color.red;
                }
                else
                {
                    dateText.color = Color.green;
                }





                //if its day 2
                //skillsText.color = Color.red;
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
        personNumber = Random.Range(1232, 18694745);

        day = Random.Range(1, 32);

        month = Random.Range(1, 13);

        year = Random.Range(1940, 2002);

        if (year <= 1975)
        {
            isTooOld = true;
        }
        else
        {
            isTooOld = false;
        }

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

            counString = goodCountry[Random.Range(0, goodCountry.Length)];

            //countryText.text = "This person is from: " + counString;

            //countryText.color = Color.green;
        }
        else
        {
            isFromGoodCountry = false;

            counString = badCountry[Random.Range(0, badCountry.Length)];

            //countryText.text = "This person is from: " + counString;

            //countryText.color = Color.green;

        }

        if (isFromGoodCountry == true)
        {
            countryText.text = "This person is from: " + counString;

            countryText.color = Color.green;
        }
        else
        {
            if (gameManage.dayNum >= 3)
            {
                countryText.text = "This person is from: " + counString;

                countryText.color = Color.red;
            }
            else
            {
                countryText.text = "This person is from: " + counString;

                countryText.color = Color.green;
            }
        }


    }

    void Forms()
    {
        nametext = GameObject.Find("Name Text").GetComponent<Text>();

        dateText = GameObject.Find("Date of Birth Text").GetComponent<Text>();

        crimianlText = GameObject.Find("Crime Text").GetComponent<Text>();

        skillsText = GameObject.Find("Skills Text").GetComponent<Text>();

        countryText = GameObject.Find("Country Text").GetComponent<Text>();


        // passportCanvas = GameObject.Find("Passport Canvas").GetComponent<Canvas>();

        formCanvas = GameObject.Find("Asuylm form Canvas").GetComponent<Canvas>();


        // passportCanvas.gameObject.SetActive(false);

        formCanvas.gameObject.SetActive(false);

    }
}
