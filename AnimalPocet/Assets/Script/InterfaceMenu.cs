using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceMenu : MonoBehaviour
{
    public GameObject foodShrimp;
    public GameObject foodSmall;
    public GameObject conGreen;
    public GameObject conYellow;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void close()
    {
        foodShrimp.SetActive(false);
        foodSmall.SetActive(false);
        conGreen.SetActive(false);
        conYellow.SetActive(false);
    }

    public void foodShrimpOpen()
    {
        foodShrimp.SetActive(true);
        foodShrimp.transform.SetAsLastSibling();
    }

    public void foodSmallOpen()
    {
        foodSmall.SetActive(true);
        foodSmall.transform.SetAsLastSibling();
    }

    public void conGreenOpen()
    {
        conGreen.SetActive(true);
        conGreen.transform.SetAsLastSibling();
    }

    public void conYellowOpen()
    {
        conYellow.SetActive(true);
        conYellow.transform.SetAsLastSibling();
    }

    public void giveShrimp()
    {
        foodShrimp.SetActive(false);
    }

    public void giveSmall()
    {
        foodSmall.SetActive(false);
    }

    public void ConGreen()
    {
        conGreen.SetActive(false);
    }

    public void ConYellow()
    {
        conYellow.SetActive(false);
    }
}
