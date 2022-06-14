using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color color1;
    public Color color2;
    Renderer render;
    // Start is called before the first frame update
    void Start()
    {
        render=GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void color1change(){
        render.material.color=color1;
    }

    public void color2change(){
        render.material.color=color2;
    }
}
