using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : PetStats
{
    protected float lefttime;
    protected float hungryrate;
    protected float happinessrate;
    protected float cleanlinessrate;
    protected float healrate;

    protected float hungrylavel;
    public new float happinessLavel = 25;
    protected float cleanLavel;
    public new float heallavel = 50;


    private void Update()
    {
        happiness(happinessLavel);
    }

    private void Start()
    {
        happiness(happinessLavel);
    }

}
