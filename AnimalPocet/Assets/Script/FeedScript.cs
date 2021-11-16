using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FeedScript : MonoBehaviour
{
    fish fish;

    TranferEven foodId = new TranferEven();

    public void foodid(UnityAction<float> listener)
    {
        foodId.AddListener(listener);
    }


    float itemfood1 = 20 , itmefood2 = 50;

    [SerializeField]
    string namefish;

    void Start()
    {
        fish = this.gameObject.GetComponent<fish>();
    }

    // Update is called once per frame
    void Update()
    {
        namefish = fish.name; 
    }

    public void feedfood1()
    {
        foodId.Invoke(itemfood1);
    }

    public void feedfood2()
    {
        foodId.Invoke(itmefood2);
    }


}
