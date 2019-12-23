using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverFisica : MonoBehaviour
{
    public float forceValue;
    public float jumpValue;
    private Rigidbody rigidbody;
    private AudioSource audio;
    public int vida;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //  Solo detecta la primera vez que         
        //Se presiona la barra espaciadora      Cuando la velocidad es muy pequeña se puede saltar
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody.velocity.y) < 0.01f)
        {
            rigidbody.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
            audio.Play();
        }

        //if (Input.acceleration.z >= 0.01 && Mathf.Abs(rigidbody.velocity.y) < 0.01f) // Cuando lo haga con el acelerometro en z
        if (Input.touchCount == 1) //-> cuando lo haga con un toque con el celular
        {
            if (Input.touches[0].phase == TouchPhase.Began && Mathf.Abs(rigidbody.velocity.y) < 0.01f)
            {
                rigidbody.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
                audio.Play();
            }

        }


    }

    void FixedUpdate()
    {
        //Movimiento con el teclado
        rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"),
                                        0,
                                        Input.GetAxis("Vertical")) * forceValue
                           );

        //Movimiento con el acelerometro del dispositivo
        rigidbody.AddForce(new Vector3(Input.acceleration.x,
                                        0,
                                        Input.acceleration.y) * forceValue
                           );
    }

    //Comprobar las colsiones con la que interactua la esfera
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            vida--;
            print("vida actual: "+vida);
            if (vida == 0)
            {
                Destroy(this.gameObject);
                print("La esfera ha muerto");
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (true)
        {
            print("Entras en la zona oscura");
        }
    }
}
