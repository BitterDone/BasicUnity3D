using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeScript : MonoBehaviour
{
	public Text redPanelText;
    // Start is called before the first frame update
    void Start()
    {
		string panelText = "sample kafka message";
		panelText += "\nsample kafka message";
		panelText += "\nsample kafka message";
		panelText += "\nsample kafka message";
		panelText += "\nsample kafka message";
		panelText += "\nsample kafka message";
		panelText += "\nsample kafka message";
		panelText += "\nsample kafka message";
		panelText += "\nsample kafka message";
		panelText += "\nsample kafka message";

		redPanelText.text = panelText;

	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
