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

    // Use this for initialization
    void Start()
    {
       // PersonalCheck();
    }

    // Update is called once per frame
    void Update()
    {
        PersonCS = personOBJ.GetComponent<Person>();

        PersonalCheck();
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
    void PersonalCheck()
    {
        if (PersonCS.isBad == true)
        {
            print("Lose Point");

            madeError = true;
        }

        if (madeError == true)
        {
            errorsNum++;

            madeError = false;

        }



        errorText.text = "Errors: " + errorsNum;

    }
}
