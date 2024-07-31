using Inventory.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UITutorialController : MonoBehaviour
{
    public GameObject tutorialScreen;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (tutorialScreen.activeSelf == false)
            {
                Show();                
            }
            else
            {
                Hide();
            }

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("FirstScene");
        }
    }

    public void Show()
    {
        tutorialScreen.SetActive(true);
    }

    public void Hide()
    {
        tutorialScreen.SetActive(false);
    }
}
