using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class Infor1 : MonoBehaviour
{
    /*public struct ToggleGroup
    {
        public Toggle sim;
        public Toggle nao;
    }*/
    public InputField[] textos;
    public Button finalizar;
    int count = 0;
    void Start(){
        finalizar.interactable = false;
    }
    public void FinalizarVerifica(){
        count = 0;
        for(int i = 0; i < textos.Length; i++){
            Debug.Log("Entrou");
            if (textos[i].text != "")
                count++;
            Debug.Log(count);
            if (count == textos.Length)
                finalizar.interactable = true;
            else
                finalizar.interactable = false;
        }
    }
    public void Finalizar(){
        SceneManager.LoadScene("INFOS 2", LoadSceneMode.Single);
    }
}
