
using UnityEngine;

public class FlashStarter : MonoBehaviour
{
    public Animator flashAnimator;

    void Start()
    {
        // This will start the default animation automatically
        flashAnimator.Play("FlashFade");
    }
}
