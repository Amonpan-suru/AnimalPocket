using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLinkScene : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("CutScene");
    }

    public void chooseAnimal()
    {
        SceneManager.LoadScene("SelectAnimal");
    }

    public void Back()
    {
        SceneManager.LoadScene("LivingRoom");
    }
}
