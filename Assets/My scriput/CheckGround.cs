using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    [SerializeField] PlayerScript _player;
    // Start is called before the first frame update
  public  bool isGround = false;  
    // Update is called once per frame
    public bool GetCheckGround()
    {
        return isGround;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            isGround = true;
            _player.Land();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //タグで着地判定
        if(collision.tag == "Ground")
        {
            isGround = false;
        }
    }
}
