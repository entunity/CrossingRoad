using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eliminar : MonoBehaviour {


    Vector3 posini;
    [SerializeField] Vector3 posfinal;
    [SerializeField] float velocidad;

    private AudioSource audio;

    // Use this for initialization
    void Start () {
        posini = this.transform.position;
        audio = this.GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = Vector3.Lerp(posini, posfinal, (Mathf.Sin(velocidad * Time.time) + 1.0f) / 2.0f);
        //this.transform.Translate(posfinal);
	}
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            Debug.Log("Objeto conseguido");
            Destroy(this.gameObject);
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Objeto conseguido");
            Destroy(this.gameObject);
            audio.Play();
        }
    }
}
