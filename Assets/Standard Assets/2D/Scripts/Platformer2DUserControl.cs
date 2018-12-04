using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof(PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        public GameObject WinPlat;
        public GameObject TrashPlat;
        public GameObject M1;
        public GameObject R1;
        public GameObject M2;
        public GameObject R2;
        public GameObject M3;
        public GameObject R3;
        public GameObject M4;
        public GameObject R4;
        public GameObject M5;
        public GameObject R5;
        public GameObject End;
        public GameObject endPlat;


        private PlatformerCharacter2D m_Character;
        private bool m_Jump;
        private bool dupText = false;
        private bool dupText2 = false;
        private bool dupText3 = false;
        private bool dupText4 = false;
        private bool dupText3M = false;
        private bool dupText3R = false;
        private bool dupText4M = false;
        private bool dupText4R = false;
        private bool dupText5M = false;
        private bool dupText5R = false;
        private bool stop = false;


        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!m_Jump && stop == false)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
        }


        private void FixedUpdate()
        {
            if (stop == false)
            {   
                // Read the inputs.
                bool crouch = Input.GetKey(KeyCode.LeftControl);
                float h = CrossPlatformInputManager.GetAxis("Horizontal");
                // Pass all parameters to the character control script.
                m_Character.Move(h, crouch, m_Jump);
                m_Jump = false;
            }
        }

        void OnTriggerEnter2D(Collider2D otherThing)
        {
            if (otherThing.tag == "NPC")
            {

                if (dupText == false)
                {
                    Instantiate(M1);
                    M1.transform.position = WinPlat.transform.position;
                    dupText = true;
                }
                if (M1.transform.position.y > 12 && dupText2 == false)
                {
                    //print("This should print a response");
                    Instantiate(R1);
                    R1.transform.position = WinPlat.transform.position;
                    dupText2 = true;
                }
            }

            if (otherThing.tag == "NPC2")
            {
                if (dupText3 == false)
                {
                    Instantiate(M2);
                    M2.transform.position = WinPlat.transform.position;
                    dupText3 = true;
                }
                if (M2.transform.position.y > 12 && dupText4 == false)
                {
                    //print("This should print a response");
                    Instantiate(R2);
                    R2.transform.position = WinPlat.transform.position;
                    dupText4 = true;
                }
            }
            if (otherThing.tag == "NPC3")
            {
                if (dupText3M == false)
                {
                    Instantiate(M3);
                    M3.transform.position = WinPlat.transform.position;
                    dupText3M = true;
                }
                if (M3.transform.position.y > 12 && dupText3R == false)
                {
                    //print("This should print a response");
                    Instantiate(R3);
                    R3.transform.position = WinPlat.transform.position;
                    dupText3R = true;
                }
            }
            if (otherThing.tag == "NPC4")
            {
                if (dupText4M == false)
                {
                    Instantiate(M4);
                    M4.transform.position = WinPlat.transform.position;
                    dupText4M = true;
                }
                if (M4.transform.position.y > 12 && dupText4R == false)
                {
                    //print("This should print a response");
                    Instantiate(R4);
                    R4.transform.position = WinPlat.transform.position;
                    dupText4R = true;
                }
            }
            if (otherThing.tag == "NPC5")
            {
                if (dupText5M == false)
                {
                    Instantiate(M5);
                    M5.transform.position = WinPlat.transform.position;
                    dupText5M = true;
                }
                if (M5.transform.position.y > 12 && dupText5R == false)
                {
                    //print("This should print a response");
                    Instantiate(R5);
                    R5.transform.position = WinPlat.transform.position;
                    dupText5R = true;
                }
            }
            if (otherThing.tag == "END" && stop== false)
            {
                Instantiate(End);
                End.transform.position = endPlat.transform.position;
                stop = true;
            }
        }
    }
}
