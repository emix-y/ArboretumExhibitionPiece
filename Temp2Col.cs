using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp2Col : MonoBehaviour
{

    public Connection cnct;

    private Renderer rndr; 

    public Color col1 = Color.white;
    public Color col2 = Color.white;

    public float minVal = 10;
    public float maxVal = 40;

    // Start is called before the first frame update
    void Start()
    {
        cnct = GameObject.FindGameObjectWithTag("Player").GetComponent<Connection>();

        rndr = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        float val = Mathf.Clamp(cnct.temp, minVal, maxVal);
        val -= minVal;
        val /= maxVal - minVal;

        Color tempCol =  Color.Lerp(col1, col2, val);

        rndr.material.color = tempCol;

    }
}
