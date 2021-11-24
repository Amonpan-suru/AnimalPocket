using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayWithFish : MonoBehaviour
{
    public GameObject loveParticle;
    fish fishScript;

    // Start is called before the first frame update
    void Start()
    {
        fishScript = this.gameObject.GetComponent<fish>();
    }


    void OnMouseDown()
    {
        fishScript.PlusHappiness();
        Instantiate(loveParticle);
        Debug.Log("hit");
    }

    
}