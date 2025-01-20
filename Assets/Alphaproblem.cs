
using UnityEngine;
using UnityEngine.UI;

// drag this script on the buttons that require to not hit Alpha transparency

public class Alphaproblem : MonoBehaviour

{   

    private Image ButtonImage;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        ButtonImage=GetComponent<Image>();
        ButtonImage.alphaHitTestMinimumThreshold = 0.5f;
        
    }

     // Update is called once per frame
    void Update()
    {
        
    }

   
}