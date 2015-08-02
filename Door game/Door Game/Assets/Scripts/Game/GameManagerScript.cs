using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {

    GameTimer gTimer;

    Door doorCS;

	// Use this for initialization
	void Start () 
    {
        gTimer = this.gameObject.GetComponent<GameTimer>();

        doorCS = GameObject.FindGameObjectWithTag("Door").GetComponent<Door>();
	
	}
	
	// Update is called once per frame
	void Update () 
    {

        if (doorCS.numEntered >= 3)
        {
            //print("Entered");
        }

        if (doorCS.numDenied >= 3)
        {
           // print("Denied");
        }



        if (gTimer.gameTime <= 0)
        {
            print("Day finished");
        }


	
	}
}
