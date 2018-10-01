using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {


    
    [SerializeField] float fuerza;
    [SerializeField] float tiempoentresaltos;
    [SerializeField] Transform posPies;

    private Rigidbody rb;
    private float tiempoactual;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        


        if (Input.GetKeyDown("space")&&Time.time>tiempoactual) {

            //comprueba q tiene alrededor de ese pto
            Collider[] cois=Physics.OverlapSphere(posPies.position, 0.1f, LayerMask.NameToLayer("Terreno"));
            for (int i = 0; i < cois.Length; i++) {
                Debug.Log(cois[i].name);
            }


            rb.AddForce(new Vector3(0f,1f,1f) *fuerza);
            tiempoactual = Time.time + tiempoentresaltos;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        else if (Input.GetKeyDown("d") && Time.time > tiempoactual)
        {
            rb.AddForce(new Vector3(1f, 1f, 0f) * fuerza);
            tiempoactual = Time.time + tiempoentresaltos;
            //transform.eulerAngles = new Vector3(0, 90, 0);
        }
        else if (Input.GetKeyDown("a") && Time.time > tiempoactual)
        {
            rb.AddForce(new Vector3(-1f, 1f, 0f) * fuerza);
            tiempoactual = Time.time + tiempoentresaltos;
            //transform.eulerAngles = new Vector3(0, -90, 0);
        }


    }
}
