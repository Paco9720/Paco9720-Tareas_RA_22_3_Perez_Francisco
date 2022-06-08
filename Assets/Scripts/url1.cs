using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class url1 : MonoBehaviour
{
    public string url;

    public void AbrirPagina(){
        Application.OpenURL(url);
    }
}
