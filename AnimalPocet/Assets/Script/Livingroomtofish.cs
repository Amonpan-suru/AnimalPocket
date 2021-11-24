using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Livingroomtofish : MonoBehaviour, IPointerDownHandler
{


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadTofish()
    {
        SceneManager.LoadScene(1);
        Debug.Log("sd");
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        loadTofish();

        Debug.Log("Load");
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(1);
        Debug.Log("sd");
    }

}
