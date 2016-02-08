// Pich code from  http://unity3d.com/learn/tutorials/modules/beginner/platform-specific/pinch-zoom
// Object selection code from 

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MultiTouchTreatment : MonoBehaviour 
{

    public int finalCode1;
    public int finalCode2;
    public int finalCode3;
    public int finalCode4;

    private GameObject selectedObject;
    private AudioSource audios;
    public AudioClip unlock;
    public bool win = false;

    /* For the sphere interaction in the book which didn't work... (it work once and then nothing!) */
    private bool isSelectedObject = false;

    void Start()
    {
        audios = GetComponent<AudioSource>();
       
    }

    void Update () 
	{
        if (!win)
        {
            Touch myTouch = Input.GetTouch(0);

            /* Check if the code has been found */
            /* These are padlock numbers game object */
            GameObject one = GameObject.Find("1");
            GameObject two = GameObject.Find("2");
            GameObject three = GameObject.Find("3");
            GameObject four = GameObject.Find("4");

            /* Check if the number on the padlock is the secret password */
             if (one.transform.Find("Text").gameObject.GetComponent<TextMesh>().text == finalCode1.ToString())
                {
                 if (two.transform.Find("Text").gameObject.GetComponent<TextMesh>().text == finalCode2.ToString())
                    {
                       if (three.transform.Find("Text").gameObject.GetComponent<TextMesh>().text == finalCode3.ToString())
                        {
                           if (four.transform.Find("Text").gameObject.GetComponent<TextMesh>().text == finalCode4.ToString())
                            {
                                // You win
                                GameObject locked = GameObject.Find("Torus");
                                locked.transform.Translate(new Vector3(0, (float)(0.007), 0));
                                audios.PlayOneShot(unlock, 0.7F);
                                GameObject winHud = GameObject.Find("Win");
                                     winHud.GetComponent<Text>().text = "Congratulation ! \n You escaped...";
                                win = true;
                                return;
                            }
                        }
                    }
                }
      

                switch (myTouch.phase)
                {
                    case TouchPhase.Began:
                            // a Ray cast from your finger(s) to the 3D screen
                            Ray screenRay = Camera.main.ScreenPointToRay(myTouch.position);

                            RaycastHit hit;
                            if (Physics.Raycast(screenRay, out hit))
                            {   // if the ray hits the padlock
                                GameObject touchObject = hit.collider.gameObject;
                                if (touchObject.name == "1" || touchObject.name == "2" || touchObject.name == "3" || touchObject.name == "4")
                                {
                                    padlockSelect(hit.collider.gameObject); // call a function to act on your object
                                }

                                /* Case where you touch the sphere 
                                else if (touchObject.name == "ballwater")
                                {
                                    /* The sphere is now the selected object *//*
                                    selectedObject = touchObject;
                                    isSelectedObject = true;
                                }*/

                            }
                            break;
                        case TouchPhase.Moved:
                            
                          /* When we move our finger whithout realeasing it
                            if (isSelectedObject)
                            {
                                ballSelect(selectedObject);
                            }
                        */
                            break;
                        
                        case TouchPhase.Ended:
                            /* No more selected object
                            isSelectedObject = false;
                            */ 
                            break;
                    }
		}
		    
    }

    /* Change the number of the padlock */
	void padlockSelect(GameObject selected){

        TextMesh number = selected.transform.Find("Text").gameObject.GetComponent<TextMesh>();
        int newNumInt = int.Parse(number.text) + 1;
        if (newNumInt > 9)
        {
            newNumInt = 0;
        }
        number.text = newNumInt.ToString();

    }

    /* To change to color of the sphere into red while moving your finger to find the hit 
    void ballSelect(GameObject selected)
    {
        selected.GetComponent<Renderer>().material.color += new Color((float)(0.03), 0, 0,1);
    }*/
}