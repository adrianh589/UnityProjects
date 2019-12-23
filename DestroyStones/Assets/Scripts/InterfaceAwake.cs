using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceAwake : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameManager.currentNumberDestroyStone = 0;
        gameManager.currentNumberStoneThrown = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void click()
    {
        Application.LoadLevel("StoneGame");
    }

}
