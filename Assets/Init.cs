using UnityEngine;
using System.Collections;

public class Init : MonoBehaviour {

	// Use this for initialization
	void Start () {

        /* Random password */ 
        float rand = Random.value;
        GameObject camera = GameObject.Find("Camera");
        MultiTouchTreatment c = camera.GetComponent<MultiTouchTreatment>();

        /* Three scenarios */
        if (rand < 0.33)
        {
            /* We set the color of the good number of "circle wood piece" puzzle in red*/
            GameObject six1 = GameObject.Find("part6(1)");
            GameObject six2 = GameObject.Find("part6(2)");

            six1.transform.GetComponent<Renderer>().material.color = new Color(1, 0, 0, .05f);
            six2.transform.GetComponent<Renderer>().material.color = new Color(1, 0, 0, .05f);

            GameObject one1 = GameObject.Find("part1(1)");
            GameObject one2 = GameObject.Find("part1(2)");

            one1.transform.GetComponent<Renderer>().material.color = new Color(1, 0, 0, .05f);
            one2.transform.GetComponent<Renderer>().material.color = new Color(1, 0, 0, .05f);

            c.finalCode1 = 6;
            c.finalCode2 = 1;

            /* We set the hint on the sphere book */
            GameObject winHud = GameObject.Find("Indice");
            winHud.GetComponent<TextMesh>().text = " ? ? 8 5";

            c.finalCode3 = 8;
            c.finalCode4 = 5;
        }
        else if (rand < 0.66)
        {
            GameObject seven1 = GameObject.Find("part7(1)");
            GameObject seven2 = GameObject.Find("part7(2)");

            seven1.transform.GetComponent<Renderer>().material.color = new Color(1, 0, 0, .05f);
            seven2.transform.GetComponent<Renderer>().material.color = new Color(1, 0, 0, .05f);

            GameObject one1 = GameObject.Find("part1(1)");
            GameObject one2 = GameObject.Find("part1(2)");

            one1.transform.GetComponent<Renderer>().material.color = new Color(1, 0, 0, .05f);
            one2.transform.GetComponent<Renderer>().material.color = new Color(1, 0, 0, .05f);

            c.finalCode1 = 7;
            c.finalCode2 = 1;

            GameObject winHud = GameObject.Find("Indice");
            winHud.GetComponent<TextMesh>().text = " ? ? 9 1";

            c.finalCode3 = 9;
            c.finalCode4 = 1;

        }
        else if (rand < 1)
        {
            GameObject seven1 = GameObject.Find("part7(1)");
            GameObject seven2 = GameObject.Find("part7(2)");

            seven1.transform.GetComponent<Renderer>().material.color = new Color(1, 0, 0, .05f);
            seven2.transform.GetComponent<Renderer>().material.color = new Color(1, 0, 0, .05f);

            GameObject six1 = GameObject.Find("part6(1)");
            GameObject six2 = GameObject.Find("part6(2)");

            six1.transform.GetComponent<Renderer>().material.color = new Color(1, 0, 0, .05f);
            six2.transform.GetComponent<Renderer>().material.color = new Color(1, 0, 0, .05f);

            c.finalCode1 = 7;
            c.finalCode2 = 6;

            GameObject winHud = GameObject.Find("Indice");
            winHud.GetComponent<TextMesh>().text = " ? ? 2 3";

            c.finalCode3 = 2;
            c.finalCode4 = 3;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
