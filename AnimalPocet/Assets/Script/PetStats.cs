using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetStats : MonoBehaviour
{
    protected float hungryrate;
    protected float happinessrate;
    protected float cleanlinessrate;
    protected float healrate;

    [SerializeField] protected float hungrylavel;
    [SerializeField] protected float happinessLavel;
    [SerializeField] protected float cleanLavel;
    [SerializeField] protected float heallavel;

    [SerializeField] GameObject dirty1, dirty2;

    protected void hungry(float hp)
    {
        if (hp <= 50 && hp >= 26)
        {
            Debug.Log("hungry"); 
        }
        if (hp <= 25 && hp >= 1)
        {
            Debug.Log("Vary hungry");
        }
        if (hp <= 0)
        {
            Debug.Log("Deadbyhungry");
        }
    }

    protected void happiness(float hp)
    {
        if (hp <= 50 && hp >= 26)
        {
            Debug.Log("sad");
            
        }
        if (hp <= 25 && hp >= 1)
        {
            Debug.Log("Vary sad");
        }
        if (hp <= 0)
        {
            Debug.Log("Deadbysad");
        }
    }

    protected void cleam(float hp)
    {

        if (hp > 50)
        {
            dirty1.SetActive(false);
            dirty2.SetActive(false);
        }
        else if (hp <= 50 && hp >= 26)
        {
            Debug.Log("dirty");
            dirty1.SetActive(true);
        }
        else if (hp <= 25 && hp >= 1)
        {
            Debug.Log("Vary dirty");
            dirty1.SetActive(false);
            dirty2.SetActive(true);
        }
        else if (hp <= 0)
        {
            Debug.Log("Deadbydirty");
        }

    }

    protected void heal(float hp)
    {
        if (hp <= 50 && hp >= 26)
        {
            Debug.Log("pain");
        }
        if (hp <= 25 && hp >= 1)
        {
            Debug.Log("Vary pain");
        }
        if (hp <= 0)
        {
            Debug.Log("Deadbypain");
        }
    }

}
