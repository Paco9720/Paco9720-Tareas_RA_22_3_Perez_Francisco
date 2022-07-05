using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Medir : MonoBehaviour
{
    //Target que utilizamos para definir su posisicon
    public Transform target;
    //Para medir la disancia
    float distanciaMinima;

    public UnityEvent susto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mide la distancia del target
        float distanciaMinima=Vector3.Distance(target.position,transform.position);
        
        //Comparamos la posicion del target para saber si esta o no esta
        if(distanciaMinima < distanciaMinima){
            Debug.Log("Objetos Tocandose");

        }
    }
}
