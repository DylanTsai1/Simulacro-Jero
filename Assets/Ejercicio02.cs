using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    public float producto1;
    public float producto2;
    public float producto3;
    public float monto;
    float sumadeproductos;
    float sobra;
    float falta;
    // Start is called before the first frame update
    void Start()
    {
        sumadeproductos = producto1 + producto2 + producto3;

       if (sumadeproductos>monto)
        {
            Debug.Log("La suma de los productos no supera el monto de dinero");
        }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
