using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {

    public int dayNum = 1;

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
            }
            else if (doorCS.numDenied >= 3)
            {
                // print("Denied");
            }
        }


        if (dayNum == 2)
        {
            if (doorCS.numEntered >= 3)
            {
                //print("Entered");

                dayNum++;
            }
            else if (doorCS.numDenied >= 3)
            {
                // print("Denied");
            }
        }


        if (dayNum == 3)
        {
            if (doorCS.numEntered >= 3)
            {
                //print("Entered");

                dayNum++;
            }
            else if (doorCS.numDenied >= 3)
            {
                // print("Denied");
            }
        }


        if (dayNum == 4)
        {
            if (doorCS.numEntered >= 3)
            {
                //print("Entered");

                dayNum++;
            }
            else if (doorCS.numDenied >= 3)
            {
                // print("Denied");
            }
        }


        if (gTimer.gameTime <= 0)
        {
            print("Day finished");
        }


	
	}

    void PersonCheck()
    {
        // If day one




        //
    }
}
