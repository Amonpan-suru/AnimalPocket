using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CleanScript : MonoBehaviour
{
    fish fish;

    TranferEven cleanID = new TranferEven();

    public void cleanid(UnityAction<float> listener)
    {
        cleanID.AddListener(listener);
    }


    void Start()
    {
        fish = this.gameObject.GetComponent<fish>();
    }


    public void cleanButton()
    {
        cleanID.Invoke(100);
    }
}
