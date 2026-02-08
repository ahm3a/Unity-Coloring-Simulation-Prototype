
using UnityEngine;
using UnityEngine.UI;

public class Paint : MonoBehaviour
{
    public Color curColor; 

    public Pencil_Color pencil;

    private Button button;

    private Image image;

    void Start()
    {
       
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);

        image = GetComponent<Image>();


    }
    void OnButtonClick()
    {
        image.color =curColor;
    }
  
}
