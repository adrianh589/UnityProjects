using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stones : MonoBehaviour {

    public GameObject explosion;
    private const float yDie = -40.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {//Cuando llegue abajo de cierta Y, destruimos las piedras
        if (transform.position.y < yDie)
        {
            Destroy(gameObject);
        }
	}
    //Cuando pulsa a una piedra, la desaparercemos
    void OnMouseDown()
    {
        //Parametris: 1: objeto a instanciar 2: posicion 3: rotacion     Transcurridos 1 segundos la explosion se elimina
        Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);//Quaternion identity no aplicara rotacion alguna, puesto que es atributo de las rotaciones
        Destroy(gameObject);
        gameManager.currentNumberDestroyStone++;
    }
}
