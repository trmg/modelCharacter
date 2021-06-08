using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Drop : MonoBehaviour
{
    
    public void initDropDown(int val)
    {
        StartGame.dificuldade = val;
    }
}
