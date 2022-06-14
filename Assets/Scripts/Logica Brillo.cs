using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LogicaBrillo : MonoBehaviour
{
    [SerializeField] Slider slide;
    [SerializeField] float sliderValue;
    [SerializeField] SpriteRenderer Brillo;

    // Start is called before the first frame update
    void Start()
    {
        slide.value = PlayerPrefs.GetFloat("Brillo", 0.5f);
        Brillo.color = new Color(Brillo.color.r, Brillo.color.g, Brillo.color.b, slide.value);
    }
    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("Brillo", sliderValue);
        Brillo.color = new Color(Brillo.color.r, Brillo.color.g, Brillo.color.b, slide.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
