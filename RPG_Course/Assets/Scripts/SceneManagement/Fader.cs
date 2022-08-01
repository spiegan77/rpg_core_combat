using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.SceneManagement
{
    public class Fader : MonoBehaviour
    {
        CanvasGroup canvasGroup;

        private void Start() 
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        // public IEnumerator FadeOutIn()
        // {
        //     yield return FadeOut(3f);
        //     print("Fadded Out");
        //     yield return FadeIn(1f);
        //     print("Faded In");
        // }
        
        public IEnumerator FadeOut(float time)
        {
            while (canvasGroup.alpha < 1)
            {
                canvasGroup.alpha += Time.deltaTime / time;
                yield return null; // makes coroutine wait for 1 frame
            }
        }

        public IEnumerator FadeIn(float time)
        {
            while (canvasGroup.alpha > 0)
            {
                canvasGroup.alpha -= Time.deltaTime / time;
                yield return null; // makes coroutine wait for 1 frame
            }
        }
    }
}
