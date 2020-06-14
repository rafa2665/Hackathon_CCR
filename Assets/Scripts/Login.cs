using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
public class Login : MonoBehaviour
{
    private IEnumerator coroutine;
    public InputField login;
    public InputField senha;
    public GameObject texto;
    void Start(){
        texto.SetActive(false);
    }
    public void Entrar(){
        if (login.text == senha.text){
            SceneManager.LoadScene("Feed", LoadSceneMode.Additive);
        }
        else{
            texto.SetActive(true);
            Debug.Log("Errou");
            coroutine = WaitAndPrint(3.0f);
            StartCoroutine(coroutine);
        }
    }
    public void CriarConta(){
        SceneManager.LoadScene("Cadastro", LoadSceneMode.Single);
    }
    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            texto.SetActive(false);
        }
    }
}
