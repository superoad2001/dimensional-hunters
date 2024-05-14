using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;


public class inventario : MonoBehaviour
{
    public bool borrar;


    
    public int indexmax = 0;

    

    public int o;
    [SerializeField]
    public datos datosserial;

    public string repath;
    public void GetFilePath()
    {
        string result;
 
    #if UNITY_EDITOR_OSX || UNITY_STANDALONE_OSX
            // mac
            result = Path.Combine(Application.streamingAssetsPath,"DHdataDemo");
            result = Path.Combine(result, $"DHdatainventario.data");
    
    #elif UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN
            // windows
            result = Path.Combine(Application.persistentDataPath,"DHdataDemo");
            result = Path.Combine(result, $"DHdatainventario.data");
    
    #elif UNITY_ANDROID
            // android
            result = Path.Combine(Application.persistentDataPath,"DHdataDemo");
            result = Path.Combine(result, $"DHdatainventario.data");
    
    #elif UNITY_IOS
            // ios
            result = Path.Combine(Application.persistentDataPath,"DHdataDemo");
            result = Path.Combine(result, $"DHdatainventario.data");
    #endif
 
        repath = result;
    }
    [ContextMenu("guardar")]
    public void guardar()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosinventario = JsonUtility.ToJson(datosserial);
            File.WriteAllText(path,datosinventario);
            Debug.Log(datosinventario);
        }
        else if(!File.Exists(path))
        {
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            file.Directory.Create();
            string datosinventario = JsonUtility.ToJson(datosserial);
            File.WriteAllText(path,datosinventario);
            Debug.Log(datosinventario);
            datosbase();
        }
        
    }
    [ContextMenu("cargar")]
    public void cargar()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosinventario = File.ReadAllText(path);
            datosserial = JsonUtility.FromJson<datos>(datosinventario);
            PlayerPrefs.SetString("plat",datosserial.plat);
            Debug.Log(datosinventario);
        }
        
    }
    public void borrar_data()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosinventario = JsonUtility.ToJson("");
            File.WriteAllText(path,datosinventario);
        }
        cargar();
        datosbase();
        
    }
    public void datosbase()
    {
        for(int i = 0;i< 30 ; i++)
        {
            datosserial.tipohierba[i] = 0;
        }
        for(int i = 0;i< 10 ; i++)
        {
            datosserial.licencia[i] = "no obtenida";
        }
        guardar();
        
    }
    // Start is called before the first frame update
    void Awake()
    {
        cargar();



    }
    void Start()
    {
        cargar();



    }

    // Update is called once per frame
    void Update()
    {

    }
    public void _borrar()
    {   
        
        for(var i = o; i < datosserial.name.Count -1; i++)
        {
            Debug.Log(i);
            datosserial.name[i] = datosserial.name[i+1];
            datosserial.hp[i] = datosserial.hp[i+1];
            datosserial.mana[i] = datosserial.mana[i+1];
            datosserial.manarec[i] = datosserial.manarec[i+1];
            datosserial.fuerza[i] = datosserial.fuerza[i+1];
            datosserial.elemento[i] = datosserial.elemento[i+1];
            datosserial.nivel[i] = datosserial.nivel[i+1];
            datosserial.clase[i] = datosserial.clase[i+1];
            datosserial.bichosmios[i] = datosserial.bichosmios[i+1];
            datosserial.exp[i] = datosserial.exp[i+1];
            datosserial.rango[i] = datosserial.rango[i+1];
            
        }
        datosserial.name.RemoveAt(datosserial.name.Count -1);
        datosserial.hp.RemoveAt(datosserial.hp.Count - 1);
        datosserial.mana.RemoveAt(datosserial.mana.Count - 1);
        datosserial.manarec.RemoveAt(datosserial.manarec.Count - 1);
        datosserial.fuerza.RemoveAt(datosserial.fuerza.Count - 1);
        datosserial.elemento.RemoveAt(datosserial.elemento.Count - 1);
        datosserial.nivel.RemoveAt(datosserial.nivel.Count - 1);
        datosserial.clase.RemoveAt(datosserial.clase.Count - 1);
        datosserial.bichosmios.RemoveAt(datosserial.bichosmios.Count - 1);
        datosserial.exp.RemoveAt(datosserial.exp.Count - 1);
        datosserial.rango.RemoveAt(datosserial.rango.Count - 1);

       
        indexmax = datosserial.name.Count;
        guardar();

        

    }
    public void _agregar2()
    {   

        indexmax = datosserial.name.Count;
        guardar();

    }


}
