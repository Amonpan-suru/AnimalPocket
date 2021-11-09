using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fish : PetStats
{
    new string name = "Tawan";

    public  float hungryrate_C = 5;
    public  float happinessrate_C = 2;
    public  float cleanlinessrate_C = 2;
    public  float healrate_C = 4;

    public  float hungrylavel_C = 100;
    public  float happinessLavel_C = 100;
    public  float cleanLavel_C = 100;
    public  float heallavel_C = 100;


    public Text HU, HA, CL, HE;
    

    private void Start()
    {
        hungrylavel = hungrylavel_C;
        happinessLavel = happinessLavel_C;
        cleanLavel = cleanLavel_C;
        heallavel = heallavel_C;
        SetStats();
    }

    void SetStats()
    {
        hungryrate = hungryrate_C;
        happinessrate = happinessrate_C;
        cleanlinessrate = cleanlinessrate_C;
        healrate = healrate_C;

    }


    private void FixedUpdate()
    {
        //lefttime += Time.deltaTime;

        hungrylavel -= (hungryrate) / 10000;
        happinessLavel -= (happinessrate) / 10000;
        cleanLavel -= (cleanlinessrate) / 10000;
        heallavel -= (healrate) / 10000;

        UpdateStats();
        SetStats();


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

        HU.text = "Hungry = " + hungrylavel;
        HA.text = "Happiness = " + happinessLavel;
        CL.text = "Clean = " + cleanLavel;
        HE.text = "Heal = " + heallavel;

    }


    private void Update()
    {
        happiness(happinessLavel);
    }

}
