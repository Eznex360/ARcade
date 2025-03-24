using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Spawn_Button : MonoBehaviour
{
    [SerializeField] Button game1;
    [SerializeField] Button game2;
    [SerializeField] Button game3;
    [SerializeField] Button game4;
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
        ratio = 400 * ((Width + Height) / 6000f);
        position = -Width / 2 + ratio / 2;
        space = (Width - 4 * ratio)/5f;
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
            float yPos = -Height/5;
            rectTransform.anchoredPosition = new Vector2(xPos, yPos);
            newButton.transform.localScale = Vector3.one* ((Width + Height) / 6000f);
            position += ratio+ space;
        }
    }
    IEnumerator WaitForResolution()
    {
        yield return new WaitForEndOfFrame();
        update_value();
        spawbutton(game1,0);
        spawbutton(game2,1);
        spawbutton(game3,2);
        spawbutton(game4,3);
    }
    
    void Start()
    {
        StartCoroutine(WaitForResolution());
    }
}
