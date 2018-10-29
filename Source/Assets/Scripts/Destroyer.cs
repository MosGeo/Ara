using System.Collections;
using UnityEngine;
using UnityEngine.UI;

class Destroyer : MonoBehaviour
{
    //Fade time in seconds
    public float fadeOutTime;

    public void Start()
    {
        FadeOut();
    }

    public void FadeOut()
    {
        StartCoroutine(FadeOutRoutine());
    }

    private IEnumerator FadeOutRoutine()
    {
        Text text = GetComponent<Text>();
        Color originalColor = text.color;

        for (float t = 0.01f; t < fadeOutTime; t += Time.deltaTime)
        {
            text.color = Color.Lerp(originalColor, Color.clear, Mathf.Min(1, t / fadeOutTime));
            yield return null;
        }
    }
}
