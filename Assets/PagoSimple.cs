using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PagoSimple : MonoBehaviour
{
    public void AbrirLinkDePago()
    {
        Application.OpenURL("https://mpago.la/241vjFG"); // Pegá tu link real
    }
}