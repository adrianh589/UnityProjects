using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTranslate : MonoBehaviour
{
    //Todo atributo publico, aparecera en el editor de Unity
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Tener en cuenta que cada parametro devuelve un 1
        //Primer param: Eje X, Segundo param: Eje y, tercer param: Eje Z
        //Input.GetAxis: Hace que se meuva con las flechas del teclado, y en String se especifica de que manera queremos que se desplace
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime,
                            0,
                            Input.GetAxis("Vertical") * speed * Time.deltaTime);//Mover en horizotntal en el eje de las X
        //Time.deltatime: Ya no sera metros * frame si no metros * segundo
    }
}
