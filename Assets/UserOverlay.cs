using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserOverlay : MonoBehaviour
{
    public GameObject title;
    
    public GameObject background;

    public GameObject StartButton;

    public GameObject MissionButton;
    
    string mainpagetitle = "Second Language\nWith AR";
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetOverlay(bool sw)
    {
        title.GetComponent<Text>().text = mainpagetitle;
        title.SetActive(sw);
        background.SetActive(sw);
        StartButton.SetActive(sw);
        MissionButton.SetActive(sw);
    }

    public void SetMissionPage(bool sw)
    {
        title.GetComponent<Text>().text = "Mission!";
        StartButton.SetActive(!sw);
        MissionButton.SetActive(!sw);
    }
}
