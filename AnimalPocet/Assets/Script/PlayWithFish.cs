using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayWithFish : MonoBehaviour
{
    public GameObject loveParticle;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseDown()
    {
        Instantiate(loveParticle);
        Debug.Log("hit");
    }

    
}