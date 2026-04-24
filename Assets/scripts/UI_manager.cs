using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_manager : MonoBehaviour
{
    public TMP_InputField inputNumero;
    public TextMeshProUGUI txtResultado;

    public int numeroActual;
    public bool numeroCargado = false;
    public string ultimoValorIngresado;

    void Start()
    {
        txtResultado.gameObject.SetActive(false);
    }

    public void MenosUno()
    {
        if (inputNumero.text != ultimoValorIngresado)
        {
            if (inputNumero.text != "")
            {
                numeroActual = int.Parse(inputNumero.text);
                ultimoValorIngresado = inputNumero.text;
                numeroCargado = true;
            }
            else
            {
                txtResultado.text = "Ingresa un numero";
                txtResultado.gameObject.SetActive(true);
                return;
            }
        }

        if (numeroActual > 0)
        {
            numeroActual--;
        }

        txtResultado.text = "Resultado: " + numeroActual;
        txtResultado.gameObject.SetActive(true);
    }
}