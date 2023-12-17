using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventario : MonoBehaviour
{
    public bool borrar;

    public List<string> name = new List<string>();
    public List<float> hp = new List<float>();
    public List<float> mana = new List<float>();
    public List<float> manarec = new List<float>();
    public List<float> fuerza = new List<float>();
    public List<string> elemento = new List<string>();
    public List<float> nivel = new List<float>();
    public List<string> bichosmios = new List<string>();
    public List<float> exp = new List<float>();
    public List<float> rango = new List<float>();
    public List<float> clase = new List<float>();
    public float dinero;
    public float hierbaomega;
    public List<string> licencia = new List<string>();

    public List<float> tipohierba = new List<float>();

    public float pocvp;
    public float pocvm;
    public float pocvg;

    public float pocmp;
    public float pocmm;
    public float pocmg;
    

    public float limite= 5;

    
    public int indexmax = 0;

    public List<string> catalogo = new List<string>();

    public int o;
    // Start is called before the first frame update
    void Start()
    {



        catalogo.Add( "skybird");
        catalogo.Add("topo topo");
        catalogo.Add("shitfloor");
        catalogo.Add("madcat");


        
        


        


        indexmax = (int)PlayerPrefs.GetFloat("index",(int)indexmax);
        for(int i = 0; i < indexmax; i++)
        {
            name.Add( PlayerPrefs.GetString("namesave"+i,"no"));
        }
        for(int i = 0;i< indexmax ; i++)
        {
            hp.Add( PlayerPrefs.GetFloat("hpsave"+i,0));
        }
        for(int i = 0;i< indexmax ; i++)
        {
            mana.Add(  PlayerPrefs.GetFloat("manasave"+i,0));
        }
        for(int i = 0;i< indexmax ; i++)
        {
            manarec.Add( PlayerPrefs.GetFloat("manarecsave"+i,0));
        }
        for(int i = 0;i< indexmax ; i++)
        {
            fuerza.Add( PlayerPrefs.GetFloat("fuerzasave"+i,0));
        }
        for(int i = 0;i< indexmax ; i++)
        {
            nivel.Add(PlayerPrefs.GetFloat("nivelsave"+i,0));
        }
        for(int i = 0;i< indexmax ; i++)
        {
            clase.Add(PlayerPrefs.GetFloat("clasesave"+i,0));
        }
        for(int i = 0;i< indexmax ; i++)
        {
            elemento.Add(  PlayerPrefs.GetString("elementosave"+i,"no"));
        }
        for(int i = 0;i< indexmax ; i++)
        {
            bichosmios.Add( PlayerPrefs.GetString("bichosmiossave"+i,"no"));
        }
        for(int i = 0;i< indexmax ; i++)
        {
            exp.Add(PlayerPrefs.GetFloat("expsave"+i,0));
        }
        for(int i = 0;i< indexmax ; i++)
        {
            rango.Add(PlayerPrefs.GetFloat("rangob"+i,0));
        }
        for(int i = 0;i< 30 ; i++)
        {
            tipohierba.Add(PlayerPrefs.GetFloat("hierba"+i,0));
        }
        for(int i = 0;i< 11 ; i++)
        {
            licencia.Add(PlayerPrefs.GetString("licencia"+i,"denegada"));
        }
        dinero = PlayerPrefs.GetFloat("dinerosave",0);

        hierbaomega = PlayerPrefs.GetFloat("hierbaomega",0);

        pocvp = PlayerPrefs.GetFloat("pocvp",2);
        pocvp = PlayerPrefs.GetFloat("pocvm",0);
        pocvp = PlayerPrefs.GetFloat("pocvg",0);

        pocmp = PlayerPrefs.GetFloat("pocmp",1);
        pocmp = PlayerPrefs.GetFloat("pocmm",0);
        pocmp = PlayerPrefs.GetFloat("pocmg",0);

        limite = PlayerPrefs.GetFloat("limite",5);


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void _borrar()
    {   
        
        for(var i = o; i < name.Count - 1; i++)
        {
            Debug.Log(i);
            name[i] = name[i+1];
            hp[i] = hp[i+1];
            mana[i] = mana[i+1];
            manarec[i] = manarec[i+1];
            fuerza[i] = fuerza[i+1];
            elemento[i] = elemento[i+1];
            nivel[i] = nivel[i+1];
            clase[i] = clase[i+1];
            bichosmios[i] = bichosmios[i+1];
            exp[i] = exp[i+1];
            rango[i] = rango[i+1];
            
        }
        name.RemoveAt(name.Count -1);
        hp.RemoveAt(hp.Count - 1);
        mana.RemoveAt(mana.Count - 1);
        manarec.RemoveAt(manarec.Count - 1);
        fuerza.RemoveAt(fuerza.Count - 1);
        elemento.RemoveAt(elemento.Count - 1);
        nivel.RemoveAt(nivel.Count - 1);
        clase.RemoveAt(clase.Count - 1);
        bichosmios.RemoveAt(bichosmios.Count - 1);
        exp.RemoveAt(exp.Count - 1);
        rango.RemoveAt(rango.Count - 1);

        for(int i = 0;i< name.Count ; i++)
        {
            PlayerPrefs.SetString("namesave"+i,name[i]);
            indexmax++;
        }
        for(int i = 0;i< hp.Count ; i++)
        {
            PlayerPrefs.SetFloat("hpsave"+i,hp[i]);
        }
        for(int i = 0;i< mana.Count ; i++)
        {
            PlayerPrefs.SetFloat("manasave"+i,mana[i]);
        }
        for(int i = 0;i< manarec.Count ; i++)
        {
            PlayerPrefs.SetFloat("manarecsave"+i,manarec[i]);
        }
        for(int i = 0;i< fuerza.Count ; i++)
        {
            PlayerPrefs.SetFloat("fuerzasave"+i,fuerza[i]);
        }
        for(int i = 0;i< nivel.Count ; i++)
        {
            PlayerPrefs.SetFloat("nivelsave"+i,nivel[i]);
        }
        for(int i = 0;i< clase.Count ; i++)
        {
            PlayerPrefs.SetFloat("clasesave"+i,clase[i]);
        }
        for(int i = 0;i< elemento.Count ; i++)
        {
            PlayerPrefs.SetString("elementosave"+i,elemento[i]);
        }
        for(int i = 0;i< bichosmios.Count ; i++)
        {
            PlayerPrefs.SetString("bichosmiossave"+i,bichosmios[i]);
        }
        for(int i = 0;i< exp.Count ; i++)
        {
            PlayerPrefs.SetFloat("expsave"+i,exp[i]);
        }
        for(int i = 0;i< rango.Count ; i++)
        {
            PlayerPrefs.SetFloat("rangob"+i,rango[i]);
        }
        indexmax = name.Count;
        PlayerPrefs.SetFloat("index",indexmax);
        

    }
    public void _agregar()
    {   
        
        name.Add("madcat");
        hp.Add(170);
        mana.Add(60);
        manarec.Add(0.5f);
        fuerza.Add(1.1f);
        elemento.Add("comun rango : 1");
        nivel.Add(1);
        clase.Add(1);
        exp.Add(0);
        rango.Add(1);
        bichosmios.Add(catalogo[3]);

        for(int i = 0;i < name.Count ; i++)
        {
            Debug.Log(name[i]);
            PlayerPrefs.SetString("namesave"+i ,name[i]);
            
        }
        for(int i = 0;i< hp.Count ; i++)
        {
            PlayerPrefs.SetFloat("hpsave"+i,hp[i]);
        }
        for(int i = 0;i< mana.Count ; i++)
        {
            PlayerPrefs.SetFloat("manasave"+i,mana[i]);
        }
        for(int i = 0;i< manarec.Count ; i++)
        {
            PlayerPrefs.SetFloat("manarecsave"+i,manarec[i]);
        }
        for(int i = 0;i< fuerza.Count ; i++)
        {
            PlayerPrefs.SetFloat("fuerzasave"+i,fuerza[i]);
        }
        for(int i = 0;i< nivel.Count ; i++)
        {
            PlayerPrefs.SetFloat("nivelsave"+i,nivel[i]);
        }
        for(int i = 0;i< clase.Count ; i++)
        {
            PlayerPrefs.SetFloat("clasesave"+i,clase[i]);
        }
        for(int i = 0;i< elemento.Count ; i++)
        {
            PlayerPrefs.SetString("elementosave"+i,elemento[i]);
        }
        for(int i = 0;i< bichosmios.Count ; i++)
        {
            PlayerPrefs.SetString("bichosmiossave"+i,bichosmios[i]);
        }
        for(int i = 0;i< exp.Count ; i++)
        {
            PlayerPrefs.SetFloat("expsave"+i,exp[i]);
        }
        for(int i = 0;i< rango.Count ; i++)
        {
            PlayerPrefs.SetFloat("rangob"+i,rango[i]);
        }
        indexmax = name.Count;
        PlayerPrefs.SetFloat("index",indexmax);
    }
    public void _agregar2()
    {   
        

        for(int i = 0;i < name.Count ; i++)
        {
            PlayerPrefs.SetString("namesave"+i ,name[i]);
            
        }
        for(int i = 0;i< hp.Count ; i++)
        {
            PlayerPrefs.SetFloat("hpsave"+i,hp[i]);
        }
        for(int i = 0;i< mana.Count ; i++)
        {
            PlayerPrefs.SetFloat("manasave"+i,mana[i]);
        }
        for(int i = 0;i< manarec.Count ; i++)
        {
            PlayerPrefs.SetFloat("manarecsave"+i,manarec[i]);
        }
        for(int i = 0;i< fuerza.Count ; i++)
        {
            PlayerPrefs.SetFloat("fuerzasave"+i,fuerza[i]);
        }
        for(int i = 0;i< nivel.Count ; i++)
        {
            PlayerPrefs.SetFloat("nivelsave"+i,nivel[i]);
        }
        for(int i = 0;i< clase.Count ; i++)
        {
            PlayerPrefs.SetFloat("clasesave"+i,clase[i]);
        }
        for(int i = 0;i< elemento.Count ; i++)
        {
            PlayerPrefs.SetString("elementosave"+i,elemento[i]);
        }
        for(int i = 0;i< bichosmios.Count ; i++)
        {
            PlayerPrefs.SetString("bichosmiossave"+i,bichosmios[i]);
        }
        for(int i = 0;i< exp.Count ; i++)
        {
            PlayerPrefs.SetFloat("expsave"+i,(int)exp[i]);
        }
        for(int i = 0;i< rango.Count ; i++)
        {
            PlayerPrefs.SetFloat("rangob"+i,(int)rango[i]);
        }
        for(int i = 0;i< tipohierba.Count ; i++)
        {
            PlayerPrefs.SetFloat("hierba"+i,(int)tipohierba[i]);
        }
        for(int i = 0;i< licencia.Count ; i++)
        {
            PlayerPrefs.SetString("licencia"+i,licencia[i]);
        }
        PlayerPrefs.SetFloat("dinerosave",dinero);

        PlayerPrefs.SetFloat("hierbaomega",hierbaomega);

        PlayerPrefs.SetFloat("pocvp",pocvp);
        PlayerPrefs.SetFloat("pocmp",pocmp);
        PlayerPrefs.SetFloat("pocvm",pocvm);
        PlayerPrefs.SetFloat("pocmm",pocmm);
        PlayerPrefs.SetFloat("pocvg",pocvg);
        PlayerPrefs.SetFloat("pocmg",pocmg);

        indexmax = name.Count;
        PlayerPrefs.SetFloat("index",indexmax);
    }


}
