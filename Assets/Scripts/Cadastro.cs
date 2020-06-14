using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Cadastro : MonoBehaviour
{
    public InputField[] textos;
    public Button criar;
    int count = 0;
    void Start(){
        criar.interactable = false;
    }
    public void CriarVerifica(){
        count = 0;
        for(int i = 0; i < textos.Length; i++){
            Debug.Log("Entrou");
            if (textos[i].text != "")
                count++;
            Debug.Log(count);
            if (count == textos.Length)
                criar.interactable = true;
            else
                criar.interactable = false;
        }
    }
    public void Criar(){
        SceneManager.LoadScene("INFOS 1", LoadSceneMode.Single);
    }
}
