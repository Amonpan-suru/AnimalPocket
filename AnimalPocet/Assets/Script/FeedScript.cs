using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FeedScript : MonoBehaviour
{
    fish fish;

    TranferEven foodId = new TranferEven();

    [SerializeField] Animator con;
    public void foodid(UnityAction<float> listener)
    {
        foodId.AddListener(listener);
    }


    float itemfood1 = 10 , itmefood2 = 20;

    [SerializeField]
    string namefish;

    void Start()
    {
        fish = this.gameObject.GetComponent<fish>();
        con = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        namefish = fish.name; 
    }

    public void feedfood1()
    {
        foodId.Invoke(itemfood1);
        con.SetTrigger("Eating");
       
    }

    public void feedfood2()
    {
        foodId.Invoke(itmefood2);
        con.SetTrigger("Eating");
    }


}
