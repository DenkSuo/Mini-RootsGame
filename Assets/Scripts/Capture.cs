using UnityEngine;

namespace DefaultNamespace
{
    public class Capture : MonoBehaviour
    {
        
        void Update(){
            if (Input.GetKeyDown(KeyCode.P))
            {
                string namefile = "acc" + UnityEngine.Random.Range(0, 99) + ".png";
                ScreenCapture.CaptureScreenshot(namefile);
                Debug.Log("OK");
            }
        }
    }
}