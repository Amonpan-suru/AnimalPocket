using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingName : MonoBehaviour
{
    public GameObject namePanel;
    private InputField animalName;


    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenNamePanel()
    {
        namePanel.SetActive(true);
    }

    public void ClosePanel()
    {
        namePanel.SetActive(false);
    }

    public void SetName()
    {
        Debug.Log(animalName.text);
        //PlayerPrefs.SetString("name", animalName.text);
        //PlayerPrefs.Save();

        
        //SceneManager.LoadScene("LivingRoom");
    }


}
