using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangMaterialfish : MonoBehaviour
{
    public Material[] materials;
    Renderer rend;
    public int x = 0;

    void Start()
    {
        rend = GameObject.Find("Fish").GetComponent<Renderer>();
       
    }
    public void state1()
    {
        rend.material = materials[0];
    }

    public void state2()
    {
        rend.material = materials[1];
    }

    public void state3()
    {
        rend.material = materials[2];
    }

    

}
