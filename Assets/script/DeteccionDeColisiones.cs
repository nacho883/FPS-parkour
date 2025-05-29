using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{

    void OncollisionEnter(Collision collision)
    {
        Debug.Log("contacto");
        Destroy(collision.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
