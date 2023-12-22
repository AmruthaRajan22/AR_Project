using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
using UnityEngine.SceneManagement;

public class GetProductChair : MonoBehaviour
{
    public static GetProductChair Instance;
    public GameObject HomePanel;
    public GameObject Description;
    public GetChair getChair;
    
    /*
    public void Sofa()
    {
        Instance = this;
        HomePanel.SetActive(false);
        Description.SetActive(true);
        getSofa = GetComponent<GetSofa>();
    }
    */

    public void Chair()
    {
        Instance = this;
        HomePanel.SetActive(false);
        Description.SetActive(true);
        getChair = GetComponent<GetChair>();
    }

    public void Back()
    {
        Instance = this;
        Description.SetActive(false);
        HomePanel.SetActive(true);
    }
}
