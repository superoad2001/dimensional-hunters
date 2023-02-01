using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Android;
using UnityEngine.UI;
using TextSpeech;
using System.Linq;
using TMPro;

public class SpeechTextManager : MonoBehaviour
{
    [SerializeField]private string language = "es-ES";

    public AudioSource audio;

     [SerializeField] private Text uitext;

    [Serializable]
    public struct VoiceCommand
    {
        public string Keyword;
        public UnityEvent Response;
    }
    public VoiceCommand[] voiceCommands;

    private Dictionary <string,UnityEvent> commands = new Dictionary<string,UnityEvent>();

    void Awake()
    {
        #if UNITY_ANDROID
        if (!Permission.HasUserAuthorizedPermission(Permission.Microphone))
        {
            Permission.RequestUserPermission(Permission.Microphone);
        }
        #endif
        foreach(var command in voiceCommands)
        {
            commands.Add(command.Keyword.ToLower(), command.Response);
        }
    }
    // Start is called before the first frame update
    void Start()
    {


        TextToSpeech.Instance.Setting(language,1,1);
        SpeechToText.Instance.Setting(language);

        SpeechToText.Instance.onResultCallback = OnFinalSpeechResult;
        

        
#if UNITY_ANDROID
        SpeechToText.Instance.onPartialResultsCallback = OnPartilSpeechResult;
#endif

        //palabrasAccion.Add("miau miau platano azul", madcat.frase1dd);
        //palabrasAccion.Add("miau miau cielo coco estrellas", madcat.frase2dd);
        //palabrasAccion.Add("miau miau puerta amarilla y verde", madcat.frase3dd);
        //palabrasAccion.Add("miau miau fuerza viscosa", madcat.frase4dd);
        //palabrasAccion.Add("miau miau tereno y aire", madcat.frase5dd);
        //palabrasAccion.Add("miau miau luz y oscuridad", madcat.frase6dd);
        //palabrasAccion.Add("miau miau vida muerte y pajaro", madcat.frase7dd);
        //palabrasAccion.Add("miau miau dos tres cuatro", madcat.frase8dd);
        //palabrasAccion.Add("miau miau ayer hoy y mañana", madcat.frase9dd);
        //palabrasAccion.Add("miau miau hola adios", madcat.frase10dd);

    }
    public void StartListening()
    {
        SpeechToText.Instance.StartRecording();
        audio.Play();
        Debug.Log("talking start ....");
    }
    public void StopListening()
    {
        SpeechToText.Instance.StopRecording();
        Debug.Log("talking stop ....");
    }
    public void OnFinalSpeechResult(string result)
    {
        uitext.text = result;
        if (result != null)
        {
            Debug.Log("comp1");
            var response = commands[result.ToLower()];
            if(result != null)
            {Debug.Log("comp2");
                response?.Invoke();
            }
        }
    }
    public void OnPartilSpeechResult(string result)
    {
        uitext.text = result;
        Debug.Log("comp3");
    }

    public void StartSpeaking(string message)
    {
        TextToSpeech.Instance.StartSpeak(message);
    }
    public void StopSpeaking(string message)
    {
        TextToSpeech.Instance.StopSpeak();
    }
    public void OnspeakStart()
    {
        
    }
    public void OnspeakStop()
    {
        Debug.Log("talking stop ....");
    }


    



}
