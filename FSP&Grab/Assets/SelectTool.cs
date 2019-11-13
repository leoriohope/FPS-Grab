
using UnityEngine;

public class SelectTool : MonoBehaviour
{
    public int SelectedTool = 0;

    // Start is called before the first frame update
    void Start()
    {
        ChooseTool();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            // Debug.Log("Weapon one choose");
            SelectedTool = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            // Debug.Log("Weapon 2 choose");
            SelectedTool = 1;
        }

        ChooseTool();
    }

    void ChooseTool() {
        int i = 0;
        foreach (Transform tool in transform) {
            if (i == SelectedTool) {
                tool.gameObject.SetActive(true);
            } else {
                tool.gameObject.SetActive(false);
            }
            i++;
        }
    }
}
