using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangMaterialfish : MonoBehaviour
{
    public Material[] materials;
    Material rend;
    public int x = 0;

    void Start()
    {
        rend = GameObject.Find("Fish").GetComponent<Material>();
       
    }
    public void state1()
    {
        rend = materials[0];
    }

    public void state2()
    {
        rend = materials[1];
    }

    public void state3()
    {
        rend = materials[2];
    }
}
