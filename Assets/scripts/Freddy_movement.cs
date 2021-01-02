using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freddy_movement : MonoBehaviour
{

    public float MovementSpeed = 1;
    public float JumpForce = 1;

    private Rigidbody2D rigidbody;
    private void Start()
    {
        rigidbody  = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
     void Update()
    {
       
      var movement = Input.GetAxis("Horizontal2");
      transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
      if(Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rigidbody.velocity.y) < 0.001f)
      {
          rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
      }

    }
    

}
