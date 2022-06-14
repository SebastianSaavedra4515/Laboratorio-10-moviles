
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LogicaVolumen : MonoBehaviour
{
    [SerializeField] Slider slide;
    [SerializeField] float sliderValue;
    
    // Start is called before the first frame update
    void Start()
    {
        slide.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume = slide.value;
        
    }
    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue) ;
        AudioListener.volume = sliderValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
