using UnityEngine;
using System.Collections;

public class ScreenFader : MonoBehaviour {

    public GameObject effectQuad;
    public Renderer effectRenderer;
    public Color effectColor;
    public Color clearColor;
    public static float lerpTime = 2;

    public static bool fadeUp;
    public static bool fadeDown;

	// Use this for initialization
	void Start () {
        fadeUp = true;
	}
	
	// Update is called once per frame
	void Update () {
	
        if( fadeDown)
        {
            effectColor = Color.Lerp(clearColor, Color.black, lerpTime);
            effectRenderer.material.color = effectColor;
            lerpTime += Time.deltaTime;
            if(lerpTime >= 2)
            {
                lerpTime = 2;
            }
        }

        if (fadeUp)
        {
            effectColor = Color.Lerp(clearColor, Color.black, lerpTime);
            effectRenderer.material.color = effectColor;
            lerpTime -= Time.deltaTime;
            if (lerpTime <= 0)
            {
                lerpTime = 0;
                fadeUp = false;
            }
        }

	}
}
