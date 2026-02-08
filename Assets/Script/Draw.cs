using UnityEngine;
using UnityEngine.UI;
public class Draw : MonoBehaviour
{
    private LineRenderer line; 
    private Vector3 previousPosition;

    [SerializeField]
     private float minDistance = 0.05f;
     private bool canDraw = false;
    
     
    

    private void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = 1;
        previousPosition = transform.position;
         line.startColor = Color.black;
        line.endColor = Color.black;
        line.startWidth = 0.05f;
        line.endWidth = 0.05f;

    }

    private void Update()
    {
        if(canDraw && Input.GetMouseButton(0))
        {
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPosition.z = 0f;

           
           if(Vector3.Distance(currentPosition,previousPosition ) > minDistance)
            {
                if(previousPosition == transform.position)
                {
                    line.SetPosition(0, currentPosition);
                }
                else
                {
                    line.positionCount++;
                    line.SetPosition(line.positionCount - 1, currentPosition);        
                }
                previousPosition = currentPosition;
            }
        }
    }
    public void EnableDrawing()
    {
        line.startColor = Color.black;
        line.endColor = Color.black;
        canDraw = true; 
    }


}
