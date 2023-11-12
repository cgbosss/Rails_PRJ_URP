using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace RailsGameEngine
{

	[AddComponentMenu("Rails Game Engine/Player Movement")]

	public class PlayerMovement : MonoBehaviour
    {
        Rigidbody2D rb2d;

        //Directions of the Movment of player
        Vector2 moveVect2;
        
        public float moveSpeed = 3;


        // Start is called before the first frame update
        void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
        
        }

        // Update is called once per frame
        void Update()
        {
			InputMovement();
		}

        //Gather the player input
        void InputMovement()
        {
            float MoveX = Input.GetAxisRaw("Horizontal");
            float MoveY = Input.GetAxisRaw("Vertical");
			moveVect2 = new Vector2(MoveX, MoveY).normalized;
		}
	    void Move()
	    {
            rb2d.velocity = new Vector2(moveVect2.x * moveSpeed, moveVect2.y * moveSpeed);    
	    }

	    void FixedUpdate()
	    {
            Move();
	    }
    }

}
