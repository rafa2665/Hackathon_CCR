using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FeedMenu : MonoBehaviour
{
    private Vector2 posInicial, posFinal;
    private bool menuMove = false;
    private bool exibindoMenu = false;
    public Image menuItens;
    public Button menuBotao;
    public Sprite[] imagensBotao;
    void Start()
    {
        menuBotao.GetComponent<Image>().sprite = imagensBotao[0];
        posInicial = new Vector2(menuItens.transform.position.x, menuItens.transform.position.y);
        posFinal = new Vector2(Screen.width * (30.0f / 100.0f), menuItens.transform.position.y);
        Debug.Log(menuItens.transform.position.x);
    }
    void FixedUpdate()
    {
        Debug.Log(menuItens.transform.position.x + " posicaox");
        if (!exibindoMenu){
            if (menuMove){
                menuItens.transform.position = Vector2.MoveTowards(menuItens.transform.position, posInicial, Time.fixedDeltaTime * 2000);
                if (menuItens.transform.position.x <= posInicial.x)
                    menuMove = false;
            }
        }
        else if (exibindoMenu){
            if (menuMove){
                menuItens.transform.position = Vector2.MoveTowards(menuItens.transform.position, posFinal, Time.fixedDeltaTime * 2000);
                if (menuItens.transform.position.x >= posFinal.x)
                    menuMove = false;
            }
        }
        else{

        }
    }
    public void MenuButtonClicked(){
        menuMove = true;
        exibindoMenu = !exibindoMenu;
        if (!exibindoMenu)
            menuBotao.GetComponent<Image>().sprite = imagensBotao[0];
        else if (exibindoMenu)
            menuBotao.GetComponent<Image>().sprite = imagensBotao[1];
    }
}
