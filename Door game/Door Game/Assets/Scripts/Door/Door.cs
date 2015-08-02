using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Door : MonoBehaviour {

    public DetectionZone DZ;

    public bool madeChoice;

    public Text questionText;


    public int numEntered;

    public Text enteredText;

    public int numDenied;

    public Text deniedText;


	// Use this for initialization
	void Start () 
    {
        DZ = GameObject.FindGameObjectWithTag("Detection").GetComponent<DetectionZone>();

        questionText.gameObject.SetActive(false);

	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (DZ.canMakeChoice == true)
        {
            questionText.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Return))
            {
                //print("Enter");

                madeChoice = true;

                DZ.canMakeChoice = false;

                DZ.personOBJ.GetComponent<Person>().canMove = true;

                DZ.gameObject.SetActive(false);

                numEntered += 1;


            }
            if (Input.GetKeyDown(KeyCode.End))
            {
               // print("End");

                DZ.personOBJ.GetComponent<Person>().denied = true;

                DZ.canMakeChoice = false;

                madeChoice = true;

                numDenied += 1;
            }
        }
        else
        {
           

            questionText.gameObject.SetActive(false);

            madeChoice = false;
        }

        enteredText.text = "People entered: " + numEntered;

        deniedText.text = "People denied: " + numDenied;
      
	}
}
