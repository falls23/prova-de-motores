using UnityEngine;
using UnityEngine.UI;
public class Painelvida : MonoBehaviour
{
    public personagem personagem;
    public Slider slidervidas;
    public Slider sliderenergia;
    void Start()
    {
        slidervidas.minValue = 0;
        slidervidas.maxValue = personagem.Getvidas();
        
        sliderenergia.minValue = 0;
        sliderenergia.maxValue = personagem.Getenergia();
    }

    
    void Update()
    {
        slidervidas.value = personagem.Getvidas();
        sliderenergia.value = personagem.Getenergia();
    }
}
