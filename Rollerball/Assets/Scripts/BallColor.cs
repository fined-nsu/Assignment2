using UnityEngine;
using UnityEngine.UI;

public class BallColor : MonoBehaviour
{
    public Dropdown dropdown;
    public Material ballShader;

    public void ChangeBallColor()
    {
        if (dropdown.value == 1)
        {
            ballShader.color = Color.red;
        }
        if (dropdown.value == 2)
        {
            ballShader.color = Color.green;
        }
        if (dropdown.value == 3)
        {
            ballShader.color = Color.blue;
        }
    }
}