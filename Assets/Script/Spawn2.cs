using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Spawn2 : MonoBehaviour
{
    [SerializeField] Button first;
    [SerializeField] Button second;
    [SerializeField] Transform parent;
    [SerializeField] Transform canva;
    
    private float ratio;
    private float position;
    private float space;
    private float Width;
    private float Height;
    
    void update_value()
    {
        Width = canva.GetComponent<RectTransform>().rect.width;
        Height = canva.GetComponent<RectTransform>().rect.height;
        ratio = 1000 * ((Width + Height) / 6000f);
        position = -Width / 2 + ratio / 2;
        space = (Width - 2 * ratio)/3f;
        position += space;
    }
    void spawbutton(Button button, int index)
    {
        Button newButton = Instantiate(button, parent);
        RectTransform rectTransform = newButton.GetComponent<RectTransform>();

        if (rectTransform != null)
        {
            rectTransform.SetParent(parent, false);
            float xPos = position ;
            float yPos = -Height/3f;
            rectTransform.anchoredPosition = new Vector2(xPos, yPos);
            newButton.transform.localScale = Vector3.one * ratio/600;
            position += ratio+ space;
        }
    }
    IEnumerator WaitForResolution()
    { 
        yield return new WaitForEndOfFrame();
        update_value();
        spawbutton(first,0);
        spawbutton(second,1);
    }
    
    void Start()
    {
        StartCoroutine(WaitForResolution());
    }
}
