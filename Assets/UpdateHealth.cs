using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text txt = GetComponent<UnityEngine.UI.Text>();
        txt.text = "Score: " + manager.instance.score.ToString();
    }
}
