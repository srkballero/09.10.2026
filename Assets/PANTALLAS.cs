using UnityEngine;
using UnityEngine.UI;

public class PANTALLAS : MonoBehaviour
{
   public GameObject[] tabs;
   public Button[] tabButttons;
   public Color SelectorcColor;
   public Color unselectedColor;
   
    void Start()
    {
        ShowTab(0);
        
        for (int i = 0; i < tabButttons.Length; i++)
        {
            int index = i;
            tabButttons[i].onClick.AddListener(delegate { ShowTab(index); });
        }
    }
    
    public void ShowTab(int index)
    {
        for (int i = 0; i < tabs.Length; i++)
        {
            if (i == index)
            {
                tabs[i].SetActive(true);
                tabButttons[i].GetComponent<Image>().color = SelectorcColor;
            }
            else
            {
                tabs[i].SetActive(false);
                tabButttons[i].GetComponent<Image>().color = unselectedColor;
            }
        }
    }
    
}

