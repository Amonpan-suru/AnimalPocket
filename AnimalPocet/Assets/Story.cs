using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story : MonoBehaviour
{
    [SerializeField]
    private float Text2Time, Text3Time, Text4Time, Text5Time;

    public GameObject Story1, Story2, Story3, Story4, Story5;
    public GameObject Text1, Text2, Text3, Text4, Text5;

    private void Awake()
    {
        Story1.SetActive(false);
        Story2.SetActive(false);
        Story3.SetActive(false);
        Story4.SetActive(false);
        Story5.SetActive(false);

        Text1.SetActive(false);
        Text2.SetActive(false);
        Text3.SetActive(false);
        Text4.SetActive(false);
        Text5.SetActive(false);
    }

    private void Start()
    {
        StartCoroutine(RunStory());
    }

    IEnumerator RunStory()
    {
        yield return new WaitForSeconds(0);
        Story1.SetActive(true);
        Text1.SetActive(true);

        yield return new WaitForSeconds(Text2Time);
        Story2.SetActive(true);
        Text2.SetActive(true);
        Story1.SetActive(false);
        Text1.SetActive(false);

        yield return new WaitForSeconds(Text3Time);
        Story3.SetActive(true);
        Text3.SetActive(true);
        Story2.SetActive(false);
        Text2.SetActive(false);

        yield return new WaitForSeconds(Text4Time);
        Story4.SetActive(true);
        Text4.SetActive(true);
        Story3.SetActive(false);
        Text3.SetActive(false);

        yield return new WaitForSeconds(Text5Time);
        Story5.SetActive(true);
        Text5.SetActive(true);
        Story4.SetActive(false);
        Text4.SetActive(false);

        yield return null;
    }

    public void SkipButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
