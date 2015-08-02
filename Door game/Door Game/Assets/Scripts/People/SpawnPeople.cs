using UnityEngine;
using System.Collections;

public class SpawnPeople : MonoBehaviour {

    public GameObject SpawnPepoleOBJ;

    Door doorCS;

    GameObject SpawnParent;

    public GameObject thisPerson;

	// Use this for initialization
	void Start () 
    {
        doorCS = GameObject.FindGameObjectWithTag("Door").GetComponent<Door>();

        SpawnParent = GameObject.Find("People");

        Instantiate(SpawnPepoleOBJ, this.gameObject.transform.position, Quaternion.identity);
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (doorCS.madeChoice == true)
        {
            //thisPerson = SpawnPepoleOBJ;

            thisPerson = Instantiate(SpawnPepoleOBJ, this.gameObject.transform.position, Quaternion.identity) as GameObject;

            thisPerson.transform.parent = SpawnParent.transform;

            
        }
	
	}
}
