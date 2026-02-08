using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Color[] ColorList;
    public Color curColor;
    public int colorCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curColor = ColorList[colorCount];
        var ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.up);
        if(Input.GetButton("Fire1"))
        {
            if(hit.collider != null)
            {
                SpriteRenderer sp = hit.collider.gameObject.GetComponent<SpriteRenderer>();
                Debug.Log(hit.collider.name);

            }
        }
    }
}
