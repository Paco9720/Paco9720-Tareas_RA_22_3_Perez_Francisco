using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
   public Vector3 ScreenPosition;
   public Vector3 wordPosition;
   Plane cubo = new Plane(Vector3.down,0);


   
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        ScreenPosition = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(ScreenPosition);
        if(cubo.Raycast(ray, out float distance)){
            wordPosition = ray.GetPoint(distance);
        }
        transform.position=wordPosition;
    }
}
