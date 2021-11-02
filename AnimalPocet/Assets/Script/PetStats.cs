using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetStats : MonoBehaviour
{

    protected float lefttime;
    protected float hungryrate;
    protected float happinessrate;
    protected float cleanlinessrate;
    protected float healrate;

    protected float hungrylavel;
    protected float happinessLavel;
    protected float cleanLavel;
    protected float heallavel;


    protected void hungry()
    {
        if (hungrylavel <= 50)
        {
            Debug.Log("hungry"); 
        }
        if (hungrylavel <= 25)
        {
            Debug.Log("Vary hungry");
        }
        if (hungrylavel <= 0)
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

    protected void cleam()
    {
        if (cleanLavel <= 50)
        {
            Debug.Log("dirty");
        }
        if (cleanLavel <= 25)
        {
            Debug.Log("Vary dirty");
        }
        if (cleanLavel <= 0)
        {
            Debug.Log("Deadbydirty");
        }
    }

    protected void heal()
    {
        if (heallavel <= 50)
        {
            Debug.Log("pain");
        }
        if (heallavel <= 25)
        {
            Debug.Log("Vary pain");
        }
        if (heallavel <= 0)
        {
            Debug.Log("Deadbypain");
        }
    }

}
