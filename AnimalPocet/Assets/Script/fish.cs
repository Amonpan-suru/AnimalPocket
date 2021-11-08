using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : PetStats
{
    new string name = "Tawan";

    public new float hungryrate = 5;
    public new float happinessrate = 2;
    public new float cleanlinessrate = 2;
    public new float healrate = 4;

    public new float hungrylavel = 100;
    public new float happinessLavel = 100;
    public new float cleanLavel = 100;
    public new float heallavel = 100;

    private void FixedUpdate()
    {
        //lefttime += Time.deltaTime;

        hungrylavel -= (hungryrate) / 100000;
        happinessLavel -= (happinessrate) / 100000;
        cleanLavel -= (cleanlinessrate) / 100000;
        heallavel -= (healrate) / 100000;

        UpdateStats();

        //if(lefttime >= 5)
        //{
        //    hungrylavel -= hungryrate;
        //    happinessLavel -= happinessrate;
        //    cleanLavel -= cleanlinessrate;
        //    heallavel -= healrate;

        //    UpdateStats();

        //    lefttime = 0;
        //}
    }

    void UpdateStats()
    {
        hungry(hungrylavel);
        happiness(happinessLavel);
        cleam(cleanLavel);
        heal(heallavel);
    }


    private void Update()
    {
        happiness(happinessLavel);
    }

    private void Start()
    {
        
    }

}
