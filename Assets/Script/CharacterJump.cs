using UnityEngine;


public class CharacterJump : MonoBehaviour
{
    public void StartJump()
    {
        transform.LeanMoveLocal(new Vector2(-2,200), 1).setEaseOutQuart().setLoopPingPong();
        
    }

}
