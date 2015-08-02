using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {

    public float gameTime;

    public Text timerText;

    //float timer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        gameTime -= Time.deltaTime;

        timerText.text = gameTime.ToString();
	
	}
}
