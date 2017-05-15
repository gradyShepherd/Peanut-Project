using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 20f;           

    Vector3 movement;                   
    Animator anim;                      
    Rigidbody playerRigidbody;         
    int floorMask;                      
    //float camRayLength = 100f;          

    void Awake()
    {
        floorMask = LayerMask.GetMask("Floor");
        anim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Move(h, v);
        Animating(h, v);
    }

    void Move(float h, float v)
    {
        movement.Set(h, 0f, v);
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);
    }

    void Animating(float h, float v)
    {
		
        if (!Input.GetButtonDown("Attack Down") && !Input.GetButtonDown("Attack Up") && 
            !Input.GetButtonDown("Attack Left") && !Input.GetButtonDown("Attack Right"))
        {
            if (v > 0)
            {
				anim.SetBool("isMoveSouth", false);
				anim.SetBool ("isMoveNorth", true);
            }
            else if (v < 0)
            {
				anim.SetBool("isMoveSouth", true);
				anim.SetBool ("isMoveNorth", false);
            }
			else
			{
				anim.SetBool ("isMoveSouth", false);
				anim.SetBool ("isMoveNorth", false);
			}

			if (h > 0) 
			{
			} 
			else if (h < 0) 
			{
				
			}
        }
    }
}