using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisioTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter () //Deja de hacer contacto
    {
        Debug.Log("Contacto");
    }

    void OnCollisionExit() //Deja de hacer contacto
    {
        Debug.Log("Dejo de hacer contacto");
    }

    void OnCollisionStay()
    {
        Debug.Log("Esta haciendo contacto");
    }
}
