using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChanger : MonoBehaviour
{
    // Array de Sprites para los fondos
    public Sprite[] backgrounds;

    // Referencia al SpriteRenderer
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Obt�n el SpriteRenderer del fondo
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Aseg�rate de que haya al menos un fondo configurado
        if (backgrounds.Length > 0)
        {
            // Selecciona un fondo aleatorio y as�gnalo
            int randomIndex = Random.Range(0, backgrounds.Length);
            spriteRenderer.sprite = backgrounds[randomIndex];
        }
        else
        {
            Debug.LogWarning("No se han asignado fondos en el array de backgrounds.");
        }
    }
}

