using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float moveSpeed = 1f;
    public float jumpSpeed = 1f;
    bool FacingRight = true;
     
    Animator playerAnimator;
    
    void Awake()
    {
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove();
        //OnGroundCheck();
        //print(Input.GetAxis("Horizontal"));
        if(playerRB.velocity.x < 0 && FacingRight)
        {
            FlipFace();
        }
        else if (playerRB.velocity.x > 0 && !FacingRight)
        {

            FlipFace();
        }
       /* if(Input.GetAxis("Vertical") > 0)
        {
            Jump();
        }
      */  
    }

    void FixedUpdate()
    {
       
    }
    void HorizontalMove ()
    {
        playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed,0f);//playerRB.velocity.y);
        playerAnimator.SetFloat("playerSpeed", Mathf.Abs(playerRB.velocity.x));
        
        
       // playerRB.velocity = new Vector2(Input.GetAxis("Horizontal"),);
    }

    void FlipFace()
    {
        FacingRight = !FacingRight;
        Vector3 TempLocalScale = transform.localScale;
        TempLocalScale.x *= -1;
        transform.localScale = TempLocalScale; 
    }

   /* void Jump()
    {
        playerRB.AddForce(new Vector2(0f, jumpSpeed));
    }

    
*/

    

    
    

}
