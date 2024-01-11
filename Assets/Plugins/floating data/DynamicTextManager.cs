using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DynamicTextManager : MonoBehaviour
{

    public static DynamicTextData defaultData;
    public static GameObject canvasPrefab;
    public static Transform mainCamera;

    public string plat;

    public Transform cam1;

    public Transform cam2;

    [SerializeField] private DynamicTextData _defaultData;
    [SerializeField] private GameObject _canvasPrefab;
    [SerializeField] private Transform _mainCamera;

    private void Awake()
    {
        plat = PlayerPrefs.GetString("plat","game3dt");
        if(plat == "arcore")
        {
            _mainCamera = cam1;
        }
        if(plat == "game3d")
        {
            _mainCamera = cam2;
        }
        if(plat == "game3dt")
        {
            _mainCamera = cam2;
        }
        
        defaultData = _defaultData;
        mainCamera = _mainCamera;
        canvasPrefab = _canvasPrefab;
    }
    public void Start()
    {
    
    }

    public void CreateText(Vector3 position, string text, DynamicTextData data)
    {
        GameObject newText = Instantiate(canvasPrefab, position, Quaternion.identity);
        newText.transform.GetComponent<DynamicText>().Initialise(text, data);
    }

}
