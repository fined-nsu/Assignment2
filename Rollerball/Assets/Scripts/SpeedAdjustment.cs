using UnityEngine;
using UnityEngine.UI;

public class SpeedAdjustment : MonoBehaviour
{
    public static float sliderSpeed;
    public Slider speedSlider;


    public void speedChange()
    {
        sliderSpeed = speedSlider.value;
    }
}
