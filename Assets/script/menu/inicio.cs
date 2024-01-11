using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inicio : MonoBehaviour
{

    public bool iniciar = false;
    public int vez1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        vez1 = PlayerPrefs.GetInt("nuevapartida",0);
    }
    public void _iniciar()
    {
        iniciar = true;
    }
    public void _borrar()
    {
        SceneManager.LoadScene("borrar");
    }
    public void _debug()
    {

        inventario inv = UnityEngine.Object.FindObjectOfType<inventario>();
        PlayerPrefs.SetFloat("limite",9999);
        PlayerPrefs.SetFloat("dinerosave",999999999);
        for(int i = 0;i< 30 ; i++)
        {
            PlayerPrefs.SetFloat("hierba"+i,999);
        }

        
                inv.name.Add("prueba");
                inv.hp.Add(9999);
                inv.mana.Add(9999);
                inv.manarec.Add(1);
                inv.fuerza.Add(1);
                inv.elemento.Add("ninguno");
                inv.nivel.Add(1);
                inv.rango.Add(1);
                inv.bichosmios.Add("madcat");
                for(int i = 0;i < inv.name.Count ; i++)
                {
                    PlayerPrefs.SetString("namesave"+i ,inv.name[i]);
                    
                }
                for(int i = 0;i< inv.hp.Count ; i++)
                {
                    PlayerPrefs.SetFloat("hpsave"+i,(int)inv.hp[i]);
                }
                for(int i = 0;i< inv.mana.Count ; i++)
                {
                    PlayerPrefs.SetFloat("manasave"+i,(int)inv.mana[i]);
                }
                for(int i = 0;i< inv.manarec.Count ; i++)
                {
                    PlayerPrefs.SetFloat("manarecsave"+i,inv.manarec[i]);
                }
                for(int i = 0;i< inv.fuerza.Count ; i++)
                {
                    PlayerPrefs.SetFloat("fuerzasave"+i,inv.fuerza[i]);
                }
                for(int i = 0;i< inv.nivel.Count ; i++)
                {
                    PlayerPrefs.SetFloat("nivelsave"+i,inv.nivel[i]);
                }
                for(int i = 0;i< inv.elemento.Count ; i++)
                {
                    PlayerPrefs.SetString("elementosave"+i,inv.elemento[i]);
                }
                for(int i = 0;i< inv.rango.Count ; i++)
                {
                    PlayerPrefs.SetFloat("rangob"+i,inv.rango[i]);
                }
                for(int i = 0;i< inv.clase.Count ; i++)
                {
                    PlayerPrefs.SetFloat("clasesave"+i,inv.clase[i]);
                }
                for(int i = 0;i< inv.bichosmios.Count ; i++)
                {
                    PlayerPrefs.SetString("bichosmiossave"+i,inv.bichosmios[i]);
                }
                inv.indexmax = inv.name.Count;
                PlayerPrefs.SetFloat("index",inv.indexmax);
    }
    // Update is called once per frame
    void Update()
    {

        if(iniciar == true && vez1 == 0)
        {
            SceneManager.LoadScene("seleccion3");
            PlayerPrefs.SetInt("nuevapartida",1);
        }
        else if(iniciar == true && vez1 == 1)
        {SceneManager.LoadScene("seleccion3");}
        iniciar = false;
    }
}
