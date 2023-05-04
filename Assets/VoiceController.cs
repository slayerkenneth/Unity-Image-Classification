using System.Collections;
using System.Collections.Generic;
using TextSpeech;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;

public class VoiceController : MonoBehaviour
{
    private bool speakerActive = false;
    const string LANG_CODE = "en-US";
    public string content;
    [SerializeField] private Text infoText;    
    [SerializeField] private GameObject voiceButton;
    [SerializeField] private hardcoder Hardcoder;

    void Start()
    {
        SetupTTS(LANG_CODE);
        TextToSpeech.Instance.onStartCallBack += OnSpeakStart;
        TextToSpeech.Instance.onDoneCallback += OnSpeakStop;
        
        CheckPermission(); 
    }

    void CheckPermission()
    {
#if UNITY_ANDROID
        if (!Permission.HasUserAuthorizedPermission(Permission.Microphone))
        {
            Permission.RequestUserPermission(Permission.Microphone);
        }
#endif
    }

    public void SetSpeak()
    {
        if (!speakerActive)
        {
            UpdateSpeakContent();
            OnSpeakStart(); 
        }
        
        else
        {
            OnSpeakStop();
            content = null;
        }
    }

    public void UpdateSpeakContent()
    {
        content = Hardcoder.GetHardcodedTextContent();
    }

    void OnSpeakStart()
    {
        if (content == null) return;
        speakerActive = true;
        TextToSpeech.Instance.StartSpeak(content);
        voiceButton.GetComponent<Image>().color = Color.red;
    }

    void OnSpeakStop()
    {
        TextToSpeech.Instance.StopSpeak(); 
        speakerActive = false;
        voiceButton.GetComponent<Image>().color = Color.white;
    }
    
    public void SetupTTS(string code)
    {
        TextToSpeech.Instance.Setting(code, 1, 1);
    }
}
