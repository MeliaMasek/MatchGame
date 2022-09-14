using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehavior : MonoBehaviour

{
    private SpriteRenderer rendererObj; 
    private void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRenderColor(ColorId obj)
    {
        rendererObj.color = obj.value;
    }
}
