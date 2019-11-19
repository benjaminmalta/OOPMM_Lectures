using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayScore : MonoBehaviour
{
    [SerializeField]Text scoreComponent;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreComponent.text = GameData.Score.ToString();
        
        
    }
}
