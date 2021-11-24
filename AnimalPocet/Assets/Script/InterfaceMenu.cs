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
    public GameObject fish;
    public GameObject bookPanel;
    public GameObject foodPanel;
    public GameObject playPanel;
    public GameObject cleanPanel;
    public GameObject healthPanel;
    public GameObject profilePanel;
    public GameObject backPanel;
    public GameObject XPanel;

    Animator bookAnimator;
    Animator foodAnimator;
    Animator playAnimator;
    Animator cleanAnimator;
    Animator healthAnimator;
    Animator profileAnimator;
    Animator backAnimator;
    Animator XAnimator;

    public int coutoffood = 0;
    public Text shrimpCount, smallfoodCount;

    public Text animalName;
    

    // Start is called before the first frame update
    void Start()
    {
        string getAnimalName = PlayerPrefs.GetString("petName");
        animalName.text = getAnimalName;
        bookAnimator = bookPanel.GetComponent<Animator>();
        foodAnimator = foodPanel.GetComponent<Animator>();
        playAnimator = playPanel.GetComponent<Animator>();
        cleanAnimator = cleanPanel.GetComponent<Animator>();
        healthAnimator = healthPanel.GetComponent<Animator>();
        profileAnimator = profilePanel.GetComponent<Animator>();
        backAnimator = backPanel.GetComponent<Animator>();
        XAnimator = XPanel.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Back()
    {
        SceneManager.LoadScene("LivingRoom");
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
        UpdateText();
    }

    public void giveSmall()
    {
        foodSmall.SetActive(false);
        UpdateText();
    }

    public void ConGreen()
    {
        conGreen.SetActive(false);
    }

    public void ConYellow()
    {
        conYellow.SetActive(false);
    }

    public void plusFoodCount()
    {
        coutoffood += 1;
        UpdateText();
    }
    public void MinusFoodCount()
    {
        if (coutoffood < 0)
        {
            coutoffood -= 1;
        }
        UpdateText();
    }

    public void UpdateText()
    {
        smallfoodCount.text = "" + coutoffood;
        shrimpCount.text = "" + coutoffood;
    }




    public void Play()
    {
        fish.GetComponent<BoxCollider>().enabled = true;
        bookAnimator.SetBool("hide", true);
        foodAnimator.SetBool("hide", true);
        playAnimator.SetBool("hide", true);
        cleanAnimator.SetBool("hide", true);
        healthAnimator.SetBool("hide", true);
        profileAnimator.SetBool("hide", true);
        backAnimator.SetBool("hide", true);
        XAnimator.SetBool("hide", true);
    }

    public void ClosePlay()
    {
        fish.GetComponent<BoxCollider>().enabled = false;
        bookAnimator.SetBool("hide", false);
        foodAnimator.SetBool("hide", false);
        playAnimator.SetBool("hide", false);
        cleanAnimator.SetBool("hide", false);
        healthAnimator.SetBool("hide", false);
        profileAnimator.SetBool("hide", false);
        backAnimator.SetBool("hide", false);
        XAnimator.SetBool("hide", false);
    }
}
