using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingName : MonoBehaviour
{
    public GameObject namePanel;
    public string newpetName = "";


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

    void Start()
    {
        var input = gameObject.GetComponent<InputField>();
        var petName = new InputField.SubmitEvent();
        petName.AddListener(SubmitName);
        input.onEndEdit = petName;
        
    }

    private void SubmitName(string getName)
    {
        PlayerPrefs.SetString("petName", getName);
        PlayerPrefs.Save();
        SceneManager.LoadScene("LivingRoom");
        
    }


}
