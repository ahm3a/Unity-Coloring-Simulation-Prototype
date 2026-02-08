using UnityEngine;
using UnityEngine.UI;

public class Pencil_Color : MonoBehaviour
{
    private GameObject pear;
    private Paint paint;
    public Color pencilColor;

    private Button button;

void Start()
    {

        button = GetComponent<Button>();
        pear = GameObject.Find("Pear");
        paint = pear.GetComponent<Paint>();
        button.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        paint.curColor = pencilColor;
    }
  

}
