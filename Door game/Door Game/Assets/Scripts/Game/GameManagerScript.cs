using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManagerScript : MonoBehaviour {

    public int dayNum = 1;

    public Text dayText;

    GameTimer gTimer;

    Door doorCS;

    Person personOBJ;

	// Use this for initialization
	void Start () 
    {
        gTimer = this.gameObject.GetComponent<GameTimer>();

        doorCS = GameObject.FindGameObjectWithTag("Door").GetComponent<Door>();

        //personOBJ = GameObject.FindGameObjectWithTag("Detection").GetComponent<DetectionZone>().personOBJ.GetComponent<Person>();
	
	}
	
	// Update is called once per frame
	void Update () 
    {

        if (dayNum == 1)
        {
            if (doorCS.numEntered >= 10)
            {
                //print("Entered");

                dayNum++;

                doorCS.numEntered = 0;

                doorCS.numDenied = 0;

                gTimer.gameTimer = 60;
            }
            else if (doorCS.numDenied >= 10)
            {
                // print("Denied");

                doorCS.numEntered = 0;

                doorCS.numDenied = 0;

                gTimer.gameTimer = 60;
                
            }
        }


        if (dayNum == 2)
        {
            if (doorCS.numEntered >= 15)
            {
                //print("Entered")

                dayNum++;

                doorCS.numEntered = 0;

                doorCS.numDenied = 0;

                gTimer.gameTimer = 60;
            }
            else if (doorCS.numDenied >= 10)
            {
                // print("Denied");

                doorCS.numEntered = 0;

                doorCS.numDenied = 0;

                gTimer.gameTimer = 60;
            }
        }


        if (dayNum == 3)
        {
            if (doorCS.numEntered >= 20)
            {
                //print("Entered");

                dayNum++;

                doorCS.numEntered = 0;

                doorCS.numDenied = 0;

                gTimer.gameTimer = 60;
            }
            else if (doorCS.numDenied >= 10)
            {
                // print("Denied");

                doorCS.numEntered = 0;

                doorCS.numDenied = 0;

                gTimer.gameTimer = 60;
            }
        }


        if (dayNum == 4)
        {
            if (doorCS.numEntered >= 5)
            {
                //print("Entered");

                //dayNum++;

                doorCS.numEntered = 0;

                doorCS.numDenied = 0;

                gTimer.gameTimer = 60;

            }
            else if (doorCS.numDenied >= 25)
            {
                // print("Denied");

                Application.LoadLevel(0);

                
            }
        }

        if (gTimer.timerRun == false)
        {
            print("Day finished");

            //check errors
            //then go to next scene
        }

        dayText.text = "Day " + dayNum.ToString();
	
	}

    void PersonCheck()
    {
        // If day one




        //
    }
}
