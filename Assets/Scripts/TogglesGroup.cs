using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TogglesGroup : MonoBehaviour
{
    public Toggle sim, nao;
    public void Selecionou(string togle){
        if (togle.Equals("sim"))
            nao.isOn = !sim.isOn;
        else if (togle.Equals("nao"))
            sim.isOn = !nao.isOn;
    }
}

