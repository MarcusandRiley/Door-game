using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndZoneCheck : MonoBehaviour
{

    public bool hasChecked;

    public GameObject personOBJ;

    Person PersonCS;

    bool madeError;

    public int errorsNum;

    public Text errorText;

    GameManagerScript gameManage;

    // Use this for initialization
    void Start()
    {
        //PersonalCheck();

        gameManage = GameObject.Find("Game Manager").GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
       PersonCS = personOBJ.GetComponent<Person>();

      // PersonalCheck();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Person")
        {
            personOBJ = col.gameObject;

            //print("Hit");

            //questionText.gameObject.SetActive(true);

            hasChecked = true;
        }
        else
        {
            hasChecked = false;
        }

    }

    void OnTriggerExit2D(Collider2D col)
    {
        PersonalCheck();
    }

    void PersonalCheck()
    {
        if (PersonCS.isBad == true)
        {
           // print("Lose Point");

            madeError = true;
        }
        else
        {
            madeError = false;
        }

        if (gameManage.dayNum >= 2)
        {
            if (PersonCS.isSkilled == false)
            {
                madeError = true;
            }
            else
            {
                madeError = false;
            }
        }

        if (gameManage.dayNum >= 3)
        {
            if (PersonCS.isFromGoodCountry == false)
            {
                madeError = true;
            }
            else
            {
                madeError = false;
            }
        }


        if (gameManage.dayNum >= 4)
        {
            if (PersonCS.isTooOld == true)
            {
                madeError = true;
            }
            else
            {
                madeError = false;
            }
        }


        if (madeError == true)
        {
            errorsNum++;

            //madeError = false;

        }

        errorText.text = "Errors: " + errorsNum;

    }
}
