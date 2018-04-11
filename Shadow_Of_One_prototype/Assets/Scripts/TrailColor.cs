using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailColor : MonoBehaviour {

    public Color colorBuffer = Color.blue;
    public MeshRenderer rend;
    private float r;
    private float g;
    private float b;

    private bool fullr;
    private bool fullg;
    private bool fullb;


	// Use this for initialization
	void Start () {
        fullr = true;
        fullg = true;
        fullb = true;
        r = 1.0f;
        g = 1.0f;
        b = 1.0f;
        colorBuffer = new Color(r, g, b, 1f);
        rend = GetComponent<MeshRenderer>();
        rend.material.color = colorBuffer;
        
    }
	// Update is called once per frame
	void Update () {
        Change();
    }

    void Change()
    {
        if (fullr == true)
        {
            r = r - .01f;
        }
        else
        {
            r += .1f;
        }
        if (fullg == true)
        {
            g = g- .01f;
        }
        else
        {
            g += .2f;
        }
        if (fullb == true)
        {
            b = b- .01f;
        }
        else
        {
            b += .01f;
        }
        Check();


    }

    void Check()
    {
        if (r < 0)
        {
            fullr = false;
        }
        else if ( r > 1)
        {
            fullr = true;
        }
        if (g < 0)
        {
            fullg = false;
        }
        else if ( g > 1)
        {
            fullg = true;
        }
        if (b < 0)
        {
            fullb = false;
        }
        else if (b > 1)
        {
            fullb = true;
        }
        SetColor();
    }

    void SetColor()
    {
        colorBuffer = new Color(r, g, b, 1f);
        rend.material.color = colorBuffer;
    }




}
