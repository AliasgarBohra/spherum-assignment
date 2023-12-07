using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform redCube;
    [SerializeField] private Transform greenCube;
    [Space(10)]
    [SerializeField] private GameObject spheresHolder;
    [Space(10)]
    [SerializeField] private TextMeshProUGUI distanceUIText;
    [Space(10)]
    [SerializeField] private float moveSpeed = 4;

    private void Start()
    {
        spheresHolder.SetActive(false);
    }
    private void Update()
    {
        #region Cube Controller

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;
        redCube.Translate(movement);

        float arrowHorizontal = Input.GetAxis("Horizontal Arrow");
        float arrowVertical = Input.GetAxis("Vertical Arrow");

        Vector3 arrowMovement = new Vector3(arrowHorizontal, 0f, arrowVertical) * moveSpeed * Time.deltaTime;
        greenCube.Translate(arrowMovement);

        #endregion

        float distance = Vector3.Distance(redCube.position, greenCube.position) - 1;
        distanceUIText.text = "<b>Distance:</b> " + distance.ToString("F2") + "m";

        if (distance < 1)
        {
            SceneManager.LoadScene("Scene 2");
        }
        else if (distance < 2)
        {
            spheresHolder.SetActive(true);
        }
        else
        {
            spheresHolder.SetActive(false);
        }
    }
}