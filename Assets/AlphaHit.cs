using UnityEngine;
using UnityEngine.UI;

// Drag this script on Buttons that require to not hit alpha transparency


public class AlphaHit : MonoBehaviour
{
private Image ButtonImage;

// Start is called before the first frame update
void Start()
{
ButtonImage=GetComponent<Image>();
ButtonImage.alphaHitTestMinimumThreshold = 0.5f;
}

}