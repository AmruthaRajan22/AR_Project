using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
using UnityEngine.SceneManagement;

public class GetProduct : MonoBehaviour
{
    public static GetProduct Instance;
    public GameObject HomePanel;
    public GameObject SofaPanel;
    public GameObject ChairPanel;
    public GameObject CabinetPanel;
    public GameObject BedPanel;
    public GameObject ClockPanel;
    public GameObject TablePanel;
    public GameObject DecorPanel;
    public GameObject MirrorPanel;
    public GameObject LampPanel;
    public GameObject CoffeePanel;

    public GetBed getBed;
    public GetCabinet getCabinet;
    public GetChair getChair;
    public GetClock getClock;
    public GetCoffee getCoffee;
    public GetDecor getDecor;
    public GetLamp getLamp;
    public GetMirror getMirror;
    public GetSofa getSofa;
    public GetTable getTable;
    
    public void Sofa()
    {
        Instance = this;
        HomePanel.SetActive(false);
        SofaPanel.SetActive(true);
        getSofa = GetComponent<GetSofa>();
    }

    public void Chair()
    {
        Instance = this;
        HomePanel.SetActive(false);
        ChairPanel.SetActive(true);
        getChair = GetComponent<GetChair>();
    }

    public void Cabinet()
    {
        Instance = this;
        HomePanel.SetActive(false);
        CabinetPanel.SetActive(true);
        getCabinet = GetComponent<GetCabinet>();
    }

    public void Bed()
    {
        Instance = this;
        HomePanel.SetActive(false);
        BedPanel.SetActive(true);
        getBed = GetComponent<GetBed>();
    }

    public void Clock()
    {
        Instance = this;
        HomePanel.SetActive(false);
        ClockPanel.SetActive(true);
        getClock = GetComponent<GetClock>();
    }

    public void Table()
    {
        Instance = this;
        HomePanel.SetActive(false);
        TablePanel.SetActive(true);
        getTable = GetComponent<GetTable>();
    }

    public void Decor()
    {
        Instance = this;
        HomePanel.SetActive(false);
        DecorPanel.SetActive(true);
        getDecor = GetComponent<GetDecor>();
    }

    public void Mirror()
    {
        Instance = this;
        HomePanel.SetActive(false);
        MirrorPanel.SetActive(true);
        getMirror = GetComponent<GetMirror>();
    }

    public void Lamp()
    {
        Instance = this;
        HomePanel.SetActive(false);
        LampPanel.SetActive(true);
        getLamp = GetComponent<GetLamp>();
    }

    public void Coffee()
    {
        Instance = this;
        HomePanel.SetActive(false);
        CoffeePanel.SetActive(true);
        getCoffee = GetComponent<GetCoffee>();
    }

    public void Back()
    {
        Instance = this;
        SofaPanel.SetActive(false);
        ChairPanel.SetActive(false);
        CabinetPanel.SetActive(false);
        BedPanel.SetActive(false);
        ClockPanel.SetActive(false);
        TablePanel.SetActive(false);
        DecorPanel.SetActive(false);
        MirrorPanel.SetActive(false);
        LampPanel.SetActive(false);
        CoffeePanel.SetActive(false);
        HomePanel.SetActive(true);
    }
}
