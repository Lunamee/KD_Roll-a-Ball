using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    [SerializeField] GameObject TitlePanel;

    private void Start()
    {
        TitlePanel.SetActive(true);
    }

    public void OnStage1StartButtonClicked()
    {
        SceneManager.LoadScene("Stage1");
    }


    public void OnReTitleButtonClicked()
    {
        TitlePanel.SetActive(true);
    }
}
