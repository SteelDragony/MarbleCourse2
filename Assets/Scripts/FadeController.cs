using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeController : MonoBehaviour {

    public Image[] toFadeImages;

	// Use this for initialization
	void Start () {
        foreach (Image img in toFadeImages)
        {
            StartCoroutine(Fade(img, 0f, 1f, 2f));
        }
	}
	
    IEnumerator Fade(Image target, float startValue, float targetValue, float duration)
    {
        float time = 0f;
        while(time < duration)
        {
            Debug.Log(target.name);
            float alpha = Mathf.Lerp(startValue, targetValue, time / duration);
            target.color = new Color(1f, 1f, 1f, alpha);
            time += Time.deltaTime;
            yield return null;
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
