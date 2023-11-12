using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RailsGameEngine
{
    [AddComponentMenu("Rails Game Engine/Player Anim Script")]

    public class PlayerAnimation : MonoBehaviour
    {

        Animator am;
        PlayerMovement PlayerMove;
        SpriteRenderer sr;

        // Start is called before the first frame update
        void Start()
        {
            am = GetComponent<Animator>();
            PlayerMove = GetComponent<PlayerMovement>();
            sr = GetComponent<SpriteRenderer>();

        }

        // Update is called once per frame
        void Update()
        {
            //Check if X/Y Vectors not 0
            //Play the Move Animation
            if (PlayerMove.moveVect2.x != 0 || PlayerMove.moveVect2.y != 0)
            {
                am.SetBool("move", true);
            }
            else
            {
				am.SetBool("move", false);
			}
        }
    }

}