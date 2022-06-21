using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rayo : MonoBehaviour
{
    //Inicio del rayo
    Transform rayoFound;
    [SerializeField]
    //La distancia del rayo
    float rayDistance;
    [SerializeField]
    //Para que funciona cada colisionador
    LayerMask layerMask;

    Image crosshair;
    public Color impact;
    public Color start;

    public GameObject choque;


    // Start is called before the first frame update
    void Start()
    {
        //Indica quien van hacer el punto de referencia
        rayoFound=Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Crear el rayo y almacenarlo
        Ray ray= new Ray(rayoFound.position,rayoFound.forward);
        //Ayuda desde donde se hace rayo y define color de este
        Debug.DrawRay(rayoFound.position,rayoFound.forward*rayDistance,Color.red);
        //Sirve para arrancar un evento, Quien almacena el nombre del colicionador con quien se hizo impacto
        RaycastHit hitinfo;
        //Maneja toda la informacion de impacto la va manejar el if es decir que pasa cuando el objeto colisiona el objeto con otro
        if (Physics.Raycast(ray,out hitinfo,rayDistance, layerMask))
        {
            if(hitinfo.collider!=null){
                crosshair.color=impact;
                
                Debug.Log("Chocaste");
            }
            
        }else{
            crosshair.color=start;
            
        }
    }
}
