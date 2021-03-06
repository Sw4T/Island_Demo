using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectMushroom : MonoBehaviour 
{

    private Animator anim;
    private GameControl gCon;

	// Use this for initialization
	void Start () 
    {
        anim = GetComponent<Animator>();
        gCon = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControl>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Pickup"))
        {
            Plunk(other.name);
            other.enabled = false;
        }
    }

    void Plunk(string name)
    {
        Debug.Log("You put a " + name + " in the pot.");
        anim.SetTrigger("Splash");
        gCon.CheckRecipie(name);
    }
}
