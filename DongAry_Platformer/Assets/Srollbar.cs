using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Srollbar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Monster;
    public Camera CM;

    private void Update()
    {
        float mosterSize = Monster.GetComponent<SpriteRenderer>().size.y * 2;
        transform.position = CM.WorldToScreenPoint(new Vector2(Monster.transform.position.x, Monster.transform.position.y+mosterSize));
    }
}
